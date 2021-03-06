using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_News.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(NewsMetadata))]
	[PrimaryKey("NewsID")]
	[TableName("[dbo].[T_News]")]
    public class T_News 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class NewsMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("NewsID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CategoryID")]
			public int CategoryID { get; set; }

			
			
			[Display(Name = "")]
			[Column("ProductCategoryID")]
			public int? ProductCategoryID { get; set; }

			
			
			[Display(Name = "")]
			[Column("RegionalID")]
			public int? RegionalID { get; set; }

			
			
			[Display(Name = "")]
			[Column("ProvID")]
			public int? ProvID { get; set; }

			
			
			[Display(Name = "")]
			[Column("SpecialID")]
			public int? SpecialID { get; set; }

			
			
			[Display(Name = "")]
			[Column("SpecialClassID")]
			public int? SpecialClassID { get; set; }

			
			
			[Display(Name = "")]
			[Column("GsID")]
			public int? GsID { get; set; }

			
			
			[Display(Name = "")]
			[Column("CompanyID")]
			public int? CompanyID { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("ShortTitle")]
			public string ShortTitle { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Title")]
			public string Title { get; set; }

			[StringLength(-1, ErrorMessage = "{0}不能超过-1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Content")]
			public string Content { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Source")]
			public string Source { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("SourceTypeID")]
			public int SourceTypeID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("PicUrl")]
			public string PicUrl { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("FileUrl")]
			public string FileUrl { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsRecommend")]
			public bool? IsRecommend { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsTop")]
			public bool? IsTop { get; set; }

			
			
			[Display(Name = "")]
			[Column("isHot")]
			public bool? IsHot { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsClubTop")]
			public bool? IsClubTop { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsNotInHome")]
			public int? IsNotInHome { get; set; }

			[StringLength(30, ErrorMessage = "{0}不能超过30个字符！")]
			
			[Display(Name = "")]
			[Column("AddBy")]
			public string AddBy { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Tags")]
			public string Tags { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("Summary")]
			public string Summary { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MHits")]
			public int MHits { get; set; }

			
			
			[Display(Name = "")]
			[Column("Hits")]
			public int? Hits { get; set; }

			
			
			[Display(Name = "审核时间")]
			[Column("CreateTime")]
			public DateTime? CreateTime { get; set; }

			
			
			[Display(Name = "0待审,1已审 2删除")]
			[Column("IsAudit")]
			public int? IsAudit { get; set; }

			
			
			[Display(Name = "")]
			[Column("Rank")]
			public int? Rank { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("OldTableName")]
			public string OldTableName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("OldTableKeyName")]
			public string OldTableKeyName { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("OldTableKeyValue")]
			public string OldTableKeyValue { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ArticleID")]
			public int ArticleID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("AuthorID")]
			public int AuthorID { get; set; }

			[StringLength(20, ErrorMessage = "{0}不能超过20个字符！")]
			
			[Display(Name = "")]
			[Column("AuthorName")]
			public string AuthorName { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Comments")]
			public int Comments { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Praises")]
			public int Praises { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Favorites")]
			public int Favorites { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("AudioUrl")]
			public string AudioUrl { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsTiming")]
			public byte IsTiming { get; set; }

			
			
			[Display(Name = "")]
			[Column("TimingTime")]
			public DateTime? TimingTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ColumnID")]
			public int ColumnID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("ComName")]
			public string ComName { get; set; }

			
			
			[Display(Name = "是否同步")]
			[Column("IsSynchronous")]
			public int? IsSynchronous { get; set; }

			
			
			[Display(Name = "")]
			[Column("MeetingID")]
			public int? MeetingID { get; set; }

			
			
			[Display(Name = "创建时间")]
			[Column("AuditTime")]
			public DateTime? AuditTime { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsGz")]
			public bool? IsGz { get; set; }

			[StringLength(335, ErrorMessage = "{0}不能超过335个字符！")]
			
			[Display(Name = "二维码")]
			[Column("NewQrCode")]
			public string NewQrCode { get; set; }

			[StringLength(335, ErrorMessage = "{0}不能超过335个字符！")]
			
			[Display(Name = "海报图")]
			[Column("NewPoster")]
			public string NewPoster { get; set; }

    }
  }      
}
