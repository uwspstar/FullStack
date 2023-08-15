# Inside look at modern web browser ( published by the chrome team )

- https://developer.chrome.com/blog/inside-browser-part1/
- https://developer.chrome.com/blog/inside-browser-part2/
- https://developer.chrome.com/blog/inside-browser-part3/
- https://developer.chrome.com/blog/inside-browser-part4/


## Notes
- If two processes need to talk, they can do so by using Inter Process Communication (`IPC`).
- Many applications are designed to work this way so that if a worker process get unresponsive, it can be restarted without stopping other processes which are running different parts of the application.

### Process and What it controls
- `Browser	Controls` "chrome" part of the application including address bar, bookmarks, back and forward buttons.
Also handles the invisible, privileged parts of a web browser such as network requests and file access.
- `Renderer`	Controls anything inside of the tab where a website is displayed.
- `Plugin`	Controls any plugins used by the website, for example, flash.
- `GPU`	Handles GPU tasks in isolation from other processes. It is separated into different process because GPUs handles requests from multiple apps and draw them in the same surface.
