using System.Net.NetworkInformation;
using ZXing.Net.Maui;

namespace RegisterLogin.Views;

public partial class ScanItemPage : ContentPage
{
	public ScanItemPage()
    {
        InitializeComponent();
        BarcodeReader.Options = new ZXing.Net.Maui.BarcodeReaderOptions
        {
            Formats = BarcodeFormat.QrCode,
            AutoRotate = true,
            Multiple = true
        };
	}

    private void BarcodeReader_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        var first = e.Results.FirstOrDefault();
        if (first == null)
            return;
;
    }
}