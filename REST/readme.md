# What is REST?
- According to wikipedia:
- The REST architectural style describes the following six constraints applied to the architecture, while leaving the implementation of the individual components free to design:

- Client–server: Servers are not concerned with the user interface or user state, so that servers can be simpler and more scalable.
- Stateless: The client–server communication is further constrained by no client context being stored on the server between requests.
- Cacheable: Responses must, implicitly or explicitly, define themselves as cacheable, or not, to prevent clients reusing stale or inappropriate data in response to further requests.
- Layered system: A client cannot ordinarily tell whether it is connected directly to the end server, or to an intermediary along the way. Intermediary servers may improve system scalability by enabling load-balancing and by providing shared caches.
- Code on demand (optional): Servers can temporarily extend or customize the functionality of a client by the transfer of executable code.
- Uniform interface: The uniform interface between clients and servers, discussed below, simplifies and decouples the architecture, which enables each part to evolve independently. (i.e. HTTP GET, POST, PUT, PATCH, DELETE)
