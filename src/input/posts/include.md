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

```html
<?# Include "./../includes/posts/toc.md" /?>
```

<?# Include "./../includes/posts/toc.md" /?>

---

## Intermediate

```html
<?! Include "./../includes/posts/toc.md" /?>
```

<?! Include "./../includes/posts/toc.md" /?>

---

## Post-rendering

```html
<?^ Include "./../includes/posts/toc.md" /?>
```

<?^ Include "./../includes/posts/toc.md" /?>

---

## Markdown

**Relative**

<?# Markdown ?>
<?!^ "./../includes/posts/toc.md" /?>
<?#/ Markdown ?>

**Absolute**

<?# Markdown ?>
<?!^ "https://raw.githubusercontent.com/alex-hedley/statiqweb-example/main/src/includes/posts/toc.md" /?>
<?#/ Markdown ?>

<!-- ## Markdown

<?# Markdown ?>
<?!^ "https://raw.githubusercontent.com/statiqdev/Statiq.Web/main/LICENSE-FAQ.md" /?>
<?#/ Markdown ?>

```html
<?# Markdown ?>
<?!^ "https://raw.githubusercontent.com/statiqdev/Statiq.Web/main/LICENSE-FAQ.md" /?>
<?#/ Markdown ?>
```

---

https://github.com/covidsafewatch/website/blob/master/input/issue-register/transparency.md?plain=1

<?# Raw ?>
<?# Include "https://github.com/foo/bar/me.md" >
<?#/ Raw ?> -->