---
title: include
tags:
    - statiq
    - web
author: alexhedley
description: Options for include shortcode
published: 2023-07-02
---

- [Processing Phases](https://www.statiq.dev/guide/content-and-data/shortcodes#processing-phases)

## Pre-rendering

<?! Raw ?>
<?# Include "./../includes/posts/toc.md" /?>
<?# Raw ?>

<?# Include "./../includes/posts/toc.md" /?>

## Intermediate

<?! Raw ?>
<?! Include "./../includes/posts/toc.md" /?>
<?# Raw ?>

<?! Include "./../includes/posts/toc.md" /?>

## Post-rendering

<?! Raw ?>
<?^ Include "./../includes/posts/toc.md" /?>
<?# Raw ?>

<?^ Include "./../includes/posts/toc.md" /?>

## Markdown

<?# Markdown ?>
<?!^ "https://raw.githubusercontent.com/statiqdev/Statiq.Web/main/LICENSE-FAQ.md" /?>
<?#/ Markdown ?>

<?! Raw ?>
<?# Markdown ?>
<?!^ "https://raw.githubusercontent.com/statiqdev/Statiq.Web/main/LICENSE-FAQ.md" /?>
<?#/ Markdown ?>
<?# Raw ?>