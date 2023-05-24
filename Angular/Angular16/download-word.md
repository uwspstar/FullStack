# downloadWord
```ts
downloadWord() {
    this.loadingDialogRef = this.dialog.open(SpinnerDialogComponent, {
      panelClass: 'custom-overlay-pane',
    });

    const DATA = document.getElementById('htmlData');

    if (!DATA) return;

    const header = "<html xmlns:o='urn:schemas-microsoft-com:office:office' " +
      "xmlns:w='urn:schemas-microsoft-com:office:word' " +
      "xmlns='http://www.w3.org/TR/REC-html40'>" +
      "<head><meta charset='utf-8'><title>Export HTML To Doc</title></head><body>";
    const footer = "</body></html>";
    const sourceHTML = header + DATA.innerHTML + footer;

    const source = 'data:application/vnd.ms-word;charset=utf-8,' + encodeURIComponent(sourceHTML);
    const fileDownload = document.createElement("a");
    document.body.appendChild(fileDownload);
    fileDownload.href = source;
    fileDownload.download = 'document.doc';
    fileDownload.click();
    document.body.removeChild(fileDownload);

    if (this.loadingDialogRef) {
      this.loadingDialogRef.close();
    }
  }
```
