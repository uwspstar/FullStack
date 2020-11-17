---
marp: true
theme: uncover
size: 16:9
paginate: true
header :"VsCode Extensions"
footer :"by Xing"
---

# VSCODE shortcuts

### VsCode Insiders
- https://code.visualstudio.com/docs/getstarted/tips-and-tricks#vscode
```
$> code-insiders -r .

Open User Settings settings.json

Keyboard Shortcut: ⌘,

Toggle Sidebar

Keyboard Shortcut: ⌘B

Navigate entire history: ctrl + Tab
```


- windows
https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf
- macos
https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf
- The guide to Visual Studio Code shortcuts, higher productivity and 30 of my favourite shortcuts you need to learn
 by lampewebdev
https://dev.to/lampewebdev/the-guide-to-visual-studio-code-shortcuts-higher-productivity-and-30-of-my-favourite-shortcuts-you-need-to-learn-mb3
- VS Code Top-Ten Pro Tips https://www.youtube.com/watch?v=u21W_tfPVrY

# VsCode Extensions

- vscode-icon
- Bracket Pair Colorizer
- Code Spell Checker
- Code Runner
- Live Server
- vscode Intellicode
- vscode-faker
- REST client

---

- draw.io integration
- Marp for VS Code
- Highlight line
- Color Highlight
- Beautify
- Import cost
- Prettier - Code formatter
- Material Icon Theme
- NuGet Package Manager

---

### user setting

```json
{
  "code-runner.runInTerminal": true,
  "workbench.sideBar.location": "right",
  "window.zoomLevel": 2,
  "editor.formatOnSave": true,
  "editor.wordWrap": "on",
  "vsicons.projectDetection.autoReload": true,
  "files.exclude": {
    "**/.git": true,
    "**/.svn": true,
    "**/.hg": true,
    "**/CVS": true,
    "**/.DS_Store": true,
    "node_modules": true
  },
  "diffEditor.ignoreTrimWhitespace": false,
  "editor.fontFamily": "'Fira Code', 'Droid Sans Mono', 'Courier New', monospace, 'Droid Sans Fallback'",
  "editor.fontLigatures": true,
  "files.autoSave": "afterDelay",
  "workbench.colorCustomizations": {
    "terminal.foreground": "#00FD61",
    "terminal.background": "#383737"
  },
  "highlightLine.borderWidth": "1px",
  "highlightLine.borderColor": "yellow",
  "git.ignoreMissingGitWarning": true,
  "files.associations": {
    "*.json": "jsonc"
  },
  "rest-client.enableTelemetry": false,
  "debug.javascript.usePreview": true,
  "python.languageServer": "Microsoft",
  "prettier.singleQuote": true,
  "liveServer.settings.donotShowInfoMsg": true,
  "javascript.updateImportsOnFileMove.enabled": "always",
  "java.home": "/Library/Java/JavaVirtualMachines/jdk-12.0.2.jdk/Contents/Home",
  "editor.suggestSelection": "first",
  "vsintellicode.modify.editor.suggestSelection": "automaticallyOverrodeDefaultValue",
  "java.errors.incompleteClasspath.severity": "ignore",
  "python.jediEnabled": false,
  "java.configuration.checkProjectSettingsExclusions": false,
  "vsicons.dontShowNewVersionMessage": true,
  "[html]": {
    "editor.defaultFormatter": "vscode.html-language-features"
  },
  "terminal.integrated.shell.osx": "/bin/bash",
  "terminal.integrated.inheritEnv": false,
  "[javascript]": {
    "editor.defaultFormatter": "vscode.typescript-language-features"
  },
  "workbench.iconTheme": "material-icon-theme",
  "cSpell.userWords": [],
  "python.insidersChannel": "off",
  "telemetry.enableTelemetry": false,
  "telemetry.enableCrashReporter": false
  //"workbench.colorTheme": "Visual Studio 2019 Dark",
}
```
