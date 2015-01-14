//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotoManager.Service.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photo
    {
        public Photo()
        {
            this.AlbumPhotoes = new HashSet<AlbumPhoto>();
        }
    
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string ImageSize { get; set; }
        public string ImageType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTimeOffset> DateCreated { get; set; }
        public string PlaceCreated { get; set; }
        public string CameraModel { get; set; }
        public string FocalLengthOfTheLens { get; set; }
        public string Diaphragm { get; set; }
        public string ShutterSpeed { get; set; }
        public string ISO { get; set; }
        public bool FlashInUse { get; set; }
        public int UserId { get; set; }
    
        public virtual ICollection<AlbumPhoto> AlbumPhotoes { get; set; }
        public virtual User User { get; set; }
    }
}