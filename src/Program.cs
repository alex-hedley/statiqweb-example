using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;
using Statiq.Alerts;

return await Bootstrapper
  .Factory
  .CreateWeb(args)
  .AddTabGroupShortCode()
  .AddIncludeCodeShortCode()
  .AddAlertShortCodes()
  .RunAsync();