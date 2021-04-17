﻿using HtmlAgilityPack;

namespace Author.Today.Epub.Converter.Extensions {
    public static class StringExtensions  {
        public static HtmlDocument AsHtmlDoc(this string self) {
            var doc = new HtmlDocument();
            doc.LoadHtml(self);
            return doc;
        }
        
        public static HtmlDocument AsXHtmlDoc(this string self) {
            HtmlNode.ElementsFlags.Remove("style");
            HtmlNode.ElementsFlags.Remove("title");

            var doc = new HtmlDocument {
                OptionFixNestedTags = true,
                OptionAutoCloseOnEnd = true,
                OptionOutputAsXml = true,
            };

            doc.LoadHtml(self);
            return doc;
        }
    }
}