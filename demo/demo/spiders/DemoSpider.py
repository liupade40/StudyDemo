import scrapy
from demo.items import DmozItem
class DmozSpider(scrapy.spiders.Spider):
    name = "dmoz"
    allowed_domains = ["dmoz.org"]
    start_urls = [
        "https://scrapy-chs.readthedocs.io/zh_CN/latest/intro/tutorial.html#id2"
    ]

    def parse(self, response):
        i=0
        for sel in response.xpath('//ul/li'):
            item = DmozItem()
            item['title'] = sel.xpath('a/text()').extract()
            i+=1
            print(i)
            print(item["title"]);
            item['link'] = sel.xpath('a/@href').extract()
            item['desc'] = sel.xpath('text()').extract()
            yield item