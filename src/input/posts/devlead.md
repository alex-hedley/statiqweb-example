---
title: Devlead.Statiq - Part 1 - Tabs
tags:
    - .NET
    - NuGet
    - C#
    - Statiq
    - Devlead.Statiq
author: devlead
description: An .NET assembly extending the static site generator Statiq with new core features
published: 2021-04-09
---

## TabGroup Shortcode

<?# TabGroup ?>
<?*
tabs:
  - name: Introduction
    content: |
      Statiq [shortcodes](https://statiq.dev/framework/content/shortcodes) are small but powerful macros that can generate content or add metadata to your documents.

      The `TabGroup` shortcode, is a CSS-only solution to simplify adding tabs in your Statiq input files.

      Why add tabs? Well with some content, a good example of that is code samples, tabs make it easier to group content together, keep things more focused and reduce user vertical scrolling.

      With the `TabGroup` shortcode tab content can be defined as either

      - Content - markdown defined directly in the shortcode content
      - Include - markdown fetched and processed from a external file
      - Code - fetch external file into markdown code fence

      the shortcode content is defined as `YAML`, you can within a single tab combine all variants (`content`, `include`, and `code`), and it'll render in the following order

      1. `content`
      1. `include`
      1. `code`

  - include: ./../includes/prerequisites.md

?>
<?#/ TabGroup ?>