# System Design

- Credit ByteByteGo Newsletter <https://blog.bytebytego.com/>
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

## The Log4j JNDI Attack and How to Prevent it

- [Zero Day Exploit Targeting Popular Java Library Log4j](https://www.govcert.ch/blog/zero-day-exploit-targeting-popular-java-library-log4j/)
- Credit GovCERT : Link: <https://lnkd.in/e4JGJ224>
- ![Zero Day Exploit Targeting Popular Java Library Log4j](https://www.govcert.ch/blog/zero-day-exploit-targeting-popular-java-library-log4j/assets/log4j_attack.png)
- Log4j is a popular Java library developed and maintained by the Apache foundation
- Remote Code Execution (RCE)
- good idea to restrict outgoing server traffic by whitelisting required traffic
- What Happened?
  - attacker insert JNDI lookup in a header field to vulnerable server
  - vulnerable server implement log4j query malicious LDAP server
  - malicious LDAP server response malicious Java code
  - vulnerable servers download and execute malicious Java code
- `TODO` : take action before execute malicious Java code (each path)
- `TODO` : what are inside the patch ?

## How do we find nearby restaurants on Yelp or Google Maps

- <https://blog.bytebytego.com/p/proximity-service>
- Given a radius and location, return a list of nearby restaurants
- [find nearby restaurants](/A-System-Design/Img/find-nearby-restaurants.png)
