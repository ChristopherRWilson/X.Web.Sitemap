﻿using X.Web.Sitemap.Example;
using X.Web.Sitemap.Example.Examples;

Console.WriteLine("OK");

IExample example1 = new SitemapGenerationWithSitemapIndexExample();
example1.Run();


IExample example2 = new SimpleSitemapGenerationExample();
example2.Run();