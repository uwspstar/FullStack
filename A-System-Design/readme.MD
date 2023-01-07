# System Design

- Credit <https://blog.bytebytego.com/>
- SDI-vol1: <https://amzn.to/3tK0qQn>
- SDI-vol2: <https://amzn.to/37ZisW9>

## Payment system

- <https://blog.bytebytego.com/p/payment-system>

- ![Payment System](/A-System-Design/Img/payment_system.png)
- `TODO` how distribute system working each components, and error handle in each step.
- what type of DB (SQL, noneSQL) is
- log system

## Match buy and sell stock orders

- <https://blog.bytebytego.com/p/match-buy-and-sell-stock-orders>
- It has a buy book (Queue) and a sell book (Queue)
- Each side of the book contains a bunch of price levels, and each price level contains a list of orders (FIFO).
- buy 2700 shares in the diagram?
- The buy order is matched with all the sell orders at price 100.10, and the first order at price 100.11 (illustrated in light red). (buy 2700 shares: 2700 - 200 - 400 -1100 - 100 - 900 = 0)
- `HashMap` ? key = price, val = [queue]
- ![Match buy and sell stock orders](/A-System-Design/Img/match-buy-and-sell-stock-orders.png)
- `TODO` write a small program to show the buy and sell 2700 shares.
- `TODO` how the best bid match the sell

## Do less on the critical path

- <https://blog.bytebytego.com/p/low-latency-stock-exchange>

- Fewer tasks on the critical path
- Less time on each task
- Fewer network hops
- Less disk usage
- Other non-critical tasks should be removed from the critical path.

## Low latency stock exchange

- <https://blog.bytebytego.com/p/low-latency-stock-exchange>
- deploy all the components in a single giant server (`no containers`)
- use `shared memory` as an event bus to communicate among the components, `no hard disk`
- key components like Order Manager and Matching Engine are `single-threaded` on the critical path, and each pinned to a CPU so that there is `no context switch` and `no locks`
- the `single-threaded` application loop executes tasks one by one in sequence
- other components listen on the `event bus` and react accordingly
- ![Low latency stock exchange](/A-System-Design/Img/low-latency-stock-exchange.png)
- `TODO` : Event Bus, memory event bus
- `TODO` : scalability (a single giant server -> vertical? any limit?)
