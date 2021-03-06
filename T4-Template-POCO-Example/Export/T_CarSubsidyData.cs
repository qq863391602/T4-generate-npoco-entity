using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CarSubsidyData.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(CarSubsidyDataMetadata))]
	[PrimaryKey("DataID")]
	[TableName("[dbo].[T_CarSubsidyData]")]
    public class T_CarSubsidyData 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class CarSubsidyDataMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("DataID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CarID")]
			public int CarID { get; set; }

			
			
			[Display(Name = "")]
			[Column("SeriesID")]
			public int? SeriesID { get; set; }

			
			
			[Display(Name = "")]
			[Column("AreaAmount")]
			public decimal? AreaAmount { get; set; }

			
			
			[Display(Name = "")]
			[Column("SubsidyID")]
			public int? SubsidyID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Year")]
			public int Year { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsEnabled")]
			public byte IsEnabled { get; set; }

			
			
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

    }
  }      
}
