using System;
using System.Collections.Generic;
namespace SmallNorthInformation
{

	//主檔
	public class Store
	{
		public String Name{ get; set;}              //店名
		public String Context {get;set;}            //說明內容 
		public String ImagePath{get;set;}	       //圖片路徑
		public String Address{ get; set; }          //地址
		public String PhoneNumber{ get; set; } //電話
		public String SasleTime {get;set;}         //營業時間
		public String StoreImagePath {get;set;} //圖片路徑
		public Double X {get;set;}                    //MapX
		public Double Y {get;set;}                    //MapY
	}

	public class  StoreTool
	{
		public static List<Store> GetAllStores()
		{
			List<Store> _result = new List<Store> ();
			_result.Add (new Store (){ Name="二聖店", PhoneNumber="(07) 335-5476", Address="高雄市前鎮區復興三路216號1樓", X=22.617894, Y=120.313589 });
			_result.Add (new Store (){ Name="自立店", PhoneNumber="(07) 323-6769", Address="高雄市三民區自立一路408號", X=22.651479, Y=120.298645 });
			_result.Add (new Store (){ Name="二聖店", PhoneNumber="(07) 335-5476", Address="高雄市前鎮區復興三路216號1樓", X=22.617894, Y=120.313589 });
			_result.Add (new Store (){ Name="二聖店", PhoneNumber="(07) 335-5476", Address="高雄市前鎮區復興三路216號1樓", X=22.617894, Y=120.313589 });
			_result.Add (new Store (){ Name="二聖店", PhoneNumber="(07) 335-5476", Address="高雄市前鎮區復興三路216號1樓", X=22.617894, Y=120.313589 });
			_result.Add (new Store (){ Name="二聖店", PhoneNumber="(07) 335-5476", Address="高雄市前鎮區復興三路216號1樓", X=22.617894, Y=120.313589 });
			_result.Add (new Store (){ Name="二聖店", PhoneNumber="(07) 335-5476", Address="高雄市前鎮區復興三路216號1樓", X=22.617894, Y=120.313589 });
			_result.Add (new Store (){ Name="二聖店", PhoneNumber="(07) 335-5476", Address="高雄市前鎮區復興三路216號1樓", X=22.617894, Y=120.313589 });
		}
	}
}

