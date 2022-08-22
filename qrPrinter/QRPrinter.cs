using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using ZXing.QrCode.Internal;
using System.Drawing;

namespace qrPrinter
{
    internal class QRPrinter
    {

        public Image GenerateQR(string text)
        {
            Image QrCodeWriteableBitmap;
            ZXing.BarcodeWriter barcodeWriter = new ZXing.BarcodeWriter { Format = ZXing.BarcodeFormat.QR_CODE, Options = { Height = 500, Width = 500 } };
            QrCodeWriteableBitmap = barcodeWriter.Write(text);
            return QrCodeWriteableBitmap;
        }

    }
}
