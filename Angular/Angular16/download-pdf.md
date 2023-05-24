# downloadPDF
```ts
downloadPDF() {
    this.loadingDialogRef = this.dialog.open(SpinnerDialogComponent, {
      panelClass: 'custom-overlay-pane',
    });

    const DATA = document.getElementById('htmlData');

    if (!DATA) return;

    html2canvas(DATA).then(canvas => {
      const imgData = canvas.toDataURL('image/png');

      // Define the dimensions of the image
      const imgWidth = 210;
      const pageHeight = 295;
      const imgHeight = canvas.height * imgWidth / canvas.width;
      let heightLeft = imgHeight;

      const doc = new jsPDF('p', 'mm');
      let position = 0;

      // Add image to each page until the image height is fully covered
      while (heightLeft >= 0) {
        position = heightLeft - imgHeight;
        doc.addImage(imgData, 'PNG', 0, position, imgWidth, imgHeight);
        heightLeft -= pageHeight;

        // Add new page only if the image height is not fully covered
        if (heightLeft >= 0) {
          doc.addPage();
        }
      }

      doc.save('demo-report.pdf');
      if (this.loadingDialogRef) {
        this.loadingDialogRef.close();
      }

    }).catch(error => {
      console.error(error);
      if (this.loadingDialogRef) {
        this.loadingDialogRef.close();
      }
    });;
  }
```
