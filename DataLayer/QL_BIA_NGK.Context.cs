﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_CHITIET_PHIEUBANHANG> tb_CHITIET_PHIEUBANHANG { get; set; }
        public virtual DbSet<tb_CHITIET_PHIEUNHAPHANG> tb_CHITIET_PHIEUNHAPHANG { get; set; }
        public virtual DbSet<tb_CHUCNANG> tb_CHUCNANG { get; set; }
        public virtual DbSet<tb_GIA> tb_GIA { get; set; }
        public virtual DbSet<tb_HANGHOA> tb_HANGHOA { get; set; }
        public virtual DbSet<tb_KHACHHANG> tb_KHACHHANG { get; set; }
        public virtual DbSet<tb_LOAIHANGHOA> tb_LOAIHANGHOA { get; set; }
        public virtual DbSet<tb_LOG> tb_LOG { get; set; }
        public virtual DbSet<tb_NHACUNGCAP> tb_NHACUNGCAP { get; set; }
        public virtual DbSet<tb_NHANVIEN> tb_NHANVIEN { get; set; }
        public virtual DbSet<tb_NHOM> tb_NHOM { get; set; }
        public virtual DbSet<tb_PHANQUYEN> tb_PHANQUYEN { get; set; }
        public virtual DbSet<tb_PHIEUBANHANG> tb_PHIEUBANHANG { get; set; }
        public virtual DbSet<tb_PHIEUCHI> tb_PHIEUCHI { get; set; }
        public virtual DbSet<tb_PHIEUNHAPHANG> tb_PHIEUNHAPHANG { get; set; }
        public virtual DbSet<tb_PHIEUTHU> tb_PHIEUTHU { get; set; }
        public virtual DbSet<tb_USER> tb_USER { get; set; }
    }
}
