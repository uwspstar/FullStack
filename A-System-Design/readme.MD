# System Design

- <https://blog.bytebytego.com/>

## Payment system

- <https://blog.bytebytego.com/p/payment-system>

- ![Payment System](/A-System-Design/Img/payment_system.png)
- [TODO] how distribute system working each components, and error handle in each step.
- log system

## Match buy and sell stock orders

- <https://blog.bytebytego.com/p/match-buy-and-sell-stock-orders>
- It has a buy book (Queue) and a sell book (Queue)
- Each side of the book contains a bunch of price levels, and each price level contains a list of orders (FIFO).
- buy 2700 shares in the diagram?
- The buy order is matched with all the sell orders at price 100.10, and the first order at price 100.11 (illustrated in light red). (buy 2700 shares: 2700 - 200 - 400 -1100 - 100 - 900 = 0)
- `HashMap` ? key = price, val = [queue]
- ![Match buy and sell stock orders](/A-System-Design/Img/match-buy-and-sell-stock-orders.png)
- [TODO] write a small program to show the buy and sell 2700 shares.
