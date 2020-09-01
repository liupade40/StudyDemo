# -*- coding: utf-8 -*-

# Define here the models for your scraped items
#
# See documentation in:
# https://doc.scrapy.org/en/latest/topics/items.html

import scrapy


def fab(max): 
    n, a, b = 0, 0, 1 
    while n < max: 
        print(111111) 
        yield b 
        print(333) 

        # print b 
        a, b = b, a + b 
        n = n + 1 
for n in fab(5):
    print(n)
    break


class DmozItem(scrapy.Item):
    title = scrapy.Field()
    link = scrapy.Field()
    desc = scrapy.Field()
