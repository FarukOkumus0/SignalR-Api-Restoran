using Microsoft.AspNetCore.Mvc;
using QRCoder;


namespace SignalRWebUI.Controllers
{
	public class QRCodeController : Controller
	{
		//System.Drawing.Common için: (view'da değişikliğe gerek yok)
		//public IActionResult Index(string value)
		//{
		//	using (MemoryStream memoryStream = new MemoryStream())
		//	{
		//		QRCodeGenerator createQRCode = new QRCodeGenerator();
		//		QRCodeGenerator.QrCode squareCode = createQRCode.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
		//		using (Bitmap image = squareCode.GetGraphic(10))
		//		{
		//			image.Save(memoryStream,ImageFormat.Png);
		//			ViewBag.QRCodeImage="data:image/png;base64" + Convert.ToBase64String(memoryStream.ToArray());
		//		}
		//	}
		//		return View();
		//}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(string value)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				QRCodeGenerator createQRCode = new QRCodeGenerator();
				QRCodeData qrCodeData = createQRCode.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
				PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
				byte[] qrCodeBytes = qrCode.GetGraphic(10);
				ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(qrCodeBytes);
			}
			return View();
		}
	}
}
