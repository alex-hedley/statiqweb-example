using System;
using System.Diagnostics;

using Statiq.Web.Modules;
using Statiq.Web.Pipelines;

using SixLabors.Fonts;
using SixLabors.ImageSharp.Drawing;
using SixLabors.ImageSharp.Drawing.Processing;

namespace StatiqBlog.Pipelines
{
	public class SocialImages : Pipeline
	{
		public SocialImages()
		{
            Dependencies.Add(nameof(Inputs));

            ProcessModules = new ModuleList
            {
                new GetPipelineDocuments(ContentType.Content),
		
		        // Filter to posts content
		        new FilterDocuments(Config.FromDocument(doc => doc.Source.Parent.Segments.Last().SequenceEqual("posts".AsMemory()))),

                new GenerateSocialImage()
            };

            OutputModules = new ModuleList { new WriteFiles() };
        }
	}

    internal class GenerateSocialImage : ParallelModule
    {
        protected override async Task<IEnumerable<IDocument>> ExecuteInputAsync(IDocument input, IExecutionContext context)
        {
            using Image _template = new Image<Rgb24>(1200, 630); // create output image of the correct dimensions

            var titleText = input.GetString("Title").ToUpper(); // fetch title from post front matter
            var brandText = "wellsb.com";

            var titleFont = SystemFonts.CreateFont("Arial", 80, FontStyle.Bold); //create fonts
            var brandFont = SystemFonts.CreateFont("Arial", 60, FontStyle.Regular);

            DrawingOptions alignCenter = new DrawingOptions()
            {
                TextOptions = new TextOptions()
                {
                    VerticalAlignment = VerticalAlignment.Center,
                    WrapTextWidth = 1160,
                    HorizontalAlignment = HorizontalAlignment.Center
                }
            };

            DrawingOptions alignRight = new DrawingOptions()
            {
                TextOptions = new TextOptions()
                {
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Right
                }
            };

            //draw rectangles
            _template.Mutate(x => x
                .Fill(Color.White, new RectangularPolygon(0, 0, 1200, 540)) //body
                .Fill(Color.Black, new RectangularPolygon(0, 540, 1200, 90)) //footer
                );

            //draw texts
            _template.Mutate(x => x
                .DrawText(alignCenter, titleText, titleFont, Color.Black, new PointF(20, 315))
                .DrawText(alignRight, brandText, brandFont, Color.White, new PointF(1165, 585))
                );

            Stream output = new MemoryStream();

            await _template.SaveAsPngAsync(output);

            var destination = $"./assets/images/featured/{input.Source.FileNameWithoutExtension}-social.png";

            var doc = context.CreateDocument( //create doc to return
                input.Source,
                destination,
                context.GetContentProvider(output));

            return new[] { doc };
        }
    }

}

