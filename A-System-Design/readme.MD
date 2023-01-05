# System Design

- <https://blog.bytebytego.com/>

## Payment system

- <https://blog.bytebytego.com/p/payment-system>

- ![Payment System](/A-System-Design/Img/payment_system.png)

## Match buy and sell stock orders

- <https://blog.bytebytego.com/p/match-buy-and-sell-stock-orders>
- It has a buy book (Queue) and a sell book (Queue)
- Each side of the book contains a bunch of price levels, and each price level contains a list of orders (FIFO).
- ![Match buy and sell stock orders](/A-System-Design/Img/match-buy-and-sell-stock-orders.png)
