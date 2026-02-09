using System;
using System.IO;
using System.Text.RegularExpressions;
using Markdig;

if (args.Length == 0)
{
    Console.Error.WriteLine("Usage: DocsConverter <docs-folder-path>");
    return 1;
}

var docsPath = args[0];

if (!Directory.Exists(docsPath))
{
    Console.Error.WriteLine($"Directory not found: {docsPath}");
    return 1;
}

var pipeline = new MarkdownPipelineBuilder()
    .UseAutoIdentifiers() // Generates id attributes on headings so that #anchor links work
    .UsePipeTables()      // Converts | pipe | tables | to <table> HTML
    .UseEmojiAndSmiley()  // Converts :emoji: shortcodes to Unicode emoji
    .Build();

// Rewrites .md links to .html in href attributes, preserving anchors and encoded spaces
var mdLinkPattern = new Regex(@"(?<=href=""[^""]*?)\.md(?=#[^""]*""|"")", RegexOptions.Compiled);

var mdFiles = Directory.GetFiles(docsPath, "*.md", SearchOption.AllDirectories);
var converted = 0;

foreach (var mdFile in mdFiles)
{
    var markdown = File.ReadAllText(mdFile);
    var html = Markdown.ToHtml(markdown, pipeline);
    html = mdLinkPattern.Replace(html, ".html");
    var htmlFile = Path.ChangeExtension(mdFile, ".html");
    File.WriteAllText(htmlFile, html);
    converted++;
}

Console.WriteLine($"Conversion complete. Converted {converted} files.");
return 0;
