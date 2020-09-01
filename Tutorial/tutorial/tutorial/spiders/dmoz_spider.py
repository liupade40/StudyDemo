import scrapy

class DmozSpider(scrapy.Spider):
    name = "dmoz"
    allowed_domains = ["dmoz.org"]
    start_urls = [
        "https://www.cnblogs.com/oldcainiao/p/4489076.html",
        
    ]

    def parse(self, response):
        filename = "baidu"
        with open(filename, 'wb') as f:
            f.write(response.body)