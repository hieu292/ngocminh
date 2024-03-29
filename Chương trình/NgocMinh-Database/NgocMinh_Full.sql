/****** Object:  ForeignKey [fk_GD_KH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_GD_KH]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
ALTER TABLE [dbo].[GiaoDichKH] DROP CONSTRAINT [fk_GD_KH]
GO
/****** Object:  ForeignKey [fk_GD_NCC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_GD_NCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
ALTER TABLE [dbo].[GiaoDichNCC] DROP CONSTRAINT [fk_GD_NCC]
GO
/****** Object:  ForeignKey [fk_PNNKH_HanTraLaiKH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKH_HanTraLaiKH]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]'))
ALTER TABLE [dbo].[HanTraLaiKH] DROP CONSTRAINT [fk_PNNKH_HanTraLaiKH]
GO
/****** Object:  ForeignKey [fk_PNNNCC_HanTraLaiNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCC_HanTraLaiNCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]'))
ALTER TABLE [dbo].[HanTraLaiNCC] DROP CONSTRAINT [fk_PNNNCC_HanTraLaiNCC]
GO
/****** Object:  ForeignKey [fk_PNNKH_HanTraNoKH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKH_HanTraNoKH]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]'))
ALTER TABLE [dbo].[HanTraNoKH] DROP CONSTRAINT [fk_PNNKH_HanTraNoKH]
GO
/****** Object:  ForeignKey [fk_PNNNCC_HanTraNoNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCC_HanTraNoNCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]'))
ALTER TABLE [dbo].[HanTraNoNCC] DROP CONSTRAINT [fk_PNNNCC_HanTraNoNCC]
GO
/****** Object:  ForeignKey [fk_NguoiDung_LoaiNguoiDung]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_NguoiDung_LoaiNguoiDung]') AND parent_object_id = OBJECT_ID(N'[dbo].[NguoiDung]'))
ALTER TABLE [dbo].[NguoiDung] DROP CONSTRAINT [fk_NguoiDung_LoaiNguoiDung]
GO
/****** Object:  ForeignKey [fk_PC_KC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PC_KC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
ALTER TABLE [dbo].[PhieuChi] DROP CONSTRAINT [fk_PC_KC]
GO
/****** Object:  ForeignKey [fk_PC_NV]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PC_NV]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
ALTER TABLE [dbo].[PhieuChi] DROP CONSTRAINT [fk_PC_NV]
GO
/****** Object:  ForeignKey [fk_PNNKH_GD]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKH_GD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [fk_PNNKH_GD]
GO
/****** Object:  ForeignKey [fk_PNNKHCT_LoaiPhieu]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKHCT_LoaiPhieu]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
ALTER TABLE [dbo].[PhieuNhanNoKHCT] DROP CONSTRAINT [fk_PNNKHCT_LoaiPhieu]
GO
/****** Object:  ForeignKey [fk_PNNKHCT_PNNKH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKHCT_PNNKH]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
ALTER TABLE [dbo].[PhieuNhanNoKHCT] DROP CONSTRAINT [fk_PNNKHCT_PNNKH]
GO
/****** Object:  ForeignKey [fk_PNNNCC_GD]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCC_GD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [fk_PNNNCC_GD]
GO
/****** Object:  ForeignKey [fk_PNNNCCCT_LoaiPhieu]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCCCT_LoaiPhieu]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
ALTER TABLE [dbo].[PhieuNhanNoNCCCT] DROP CONSTRAINT [fk_PNNNCCCT_LoaiPhieu]
GO
/****** Object:  ForeignKey [fk_PNNNCCCT_PNNNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCCCT_PNNNCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
ALTER TABLE [dbo].[PhieuNhanNoNCCCT] DROP CONSTRAINT [fk_PNNNCCCT_PNNNCC]
GO
/****** Object:  ForeignKey [fk_PT_KH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PT_KH]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
ALTER TABLE [dbo].[PhieuThu] DROP CONSTRAINT [fk_PT_KH]
GO
/****** Object:  ForeignKey [fk_PT_KT]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PT_KT]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
ALTER TABLE [dbo].[PhieuThu] DROP CONSTRAINT [fk_PT_KT]
GO
/****** Object:  Check [CK__GiaoDichK__SoTie__1BFD2C07]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1BFD2C07]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1BFD2C07]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
ALTER TABLE [dbo].[GiaoDichKH] DROP CONSTRAINT [CK__GiaoDichK__SoTie__1BFD2C07]

END
GO
/****** Object:  Check [CK__GiaoDichK__SoTie__1DE57479]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1DE57479]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1DE57479]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
ALTER TABLE [dbo].[GiaoDichKH] DROP CONSTRAINT [CK__GiaoDichK__SoTie__1DE57479]

END
GO
/****** Object:  Check [CK__GiaoDichK__SoTie__1FCDBCEB]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1FCDBCEB]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1FCDBCEB]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
ALTER TABLE [dbo].[GiaoDichKH] DROP CONSTRAINT [CK__GiaoDichK__SoTie__1FCDBCEB]

END
GO
/****** Object:  Check [CK__GiaoDichN__SoTie__531856C7]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__531856C7]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__531856C7]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
ALTER TABLE [dbo].[GiaoDichNCC] DROP CONSTRAINT [CK__GiaoDichN__SoTie__531856C7]

END
GO
/****** Object:  Check [CK__GiaoDichN__SoTie__55009F39]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__55009F39]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__55009F39]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
ALTER TABLE [dbo].[GiaoDichNCC] DROP CONSTRAINT [CK__GiaoDichN__SoTie__55009F39]

END
GO
/****** Object:  Check [CK__GiaoDichN__SoTie__56E8E7AB]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__56E8E7AB]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__56E8E7AB]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
ALTER TABLE [dbo].[GiaoDichNCC] DROP CONSTRAINT [CK__GiaoDichN__SoTie__56E8E7AB]

END
GO
/****** Object:  Check [CK__HanTraLai__KyHan__4E1E9780]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraLai__KyHan__4E1E9780]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraLai__KyHan__4E1E9780]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]'))
ALTER TABLE [dbo].[HanTraLaiKH] DROP CONSTRAINT [CK__HanTraLai__KyHan__4E1E9780]

END
GO
/****** Object:  Check [CK__HanTraLai__KyHan__57A801BA]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraLai__KyHan__57A801BA]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraLai__KyHan__57A801BA]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]'))
ALTER TABLE [dbo].[HanTraLaiNCC] DROP CONSTRAINT [CK__HanTraLai__KyHan__57A801BA]

END
GO
/****** Object:  Check [CK__HanTraNoK__KyHan__52E34C9D]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraNoK__KyHan__52E34C9D]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraNoK__KyHan__52E34C9D]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]'))
ALTER TABLE [dbo].[HanTraNoKH] DROP CONSTRAINT [CK__HanTraNoK__KyHan__52E34C9D]

END
GO
/****** Object:  Check [CK__HanTraNoN__KyHan__5C6CB6D7]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraNoN__KyHan__5C6CB6D7]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraNoN__KyHan__5C6CB6D7]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]'))
ALTER TABLE [dbo].[HanTraNoNCC] DROP CONSTRAINT [CK__HanTraNoN__KyHan__5C6CB6D7]

END
GO
/****** Object:  Check [CK__PhieuChi__SoTien__2180FB33]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuChi__SoTien__2180FB33]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuChi__SoTien__2180FB33]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
ALTER TABLE [dbo].[PhieuChi] DROP CONSTRAINT [CK__PhieuChi__SoTien__2180FB33]

END
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__2DE6D218]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__2DE6D218]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__2DE6D218]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [CK__PhieuNhan__KyHan__2DE6D218]

END
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__2FCF1A8A]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__2FCF1A8A]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__2FCF1A8A]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [CK__PhieuNhan__KyHan__2FCF1A8A]

END
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__31B762FC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__31B762FC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__31B762FC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [CK__PhieuNhan__KyHan__31B762FC]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__2739D489]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__2739D489]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__2739D489]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [CK__PhieuNhan__SoTie__2739D489]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__29221CFB]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__29221CFB]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__29221CFB]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [CK__PhieuNhan__SoTie__29221CFB]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__2B0A656D]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__2B0A656D]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__2B0A656D]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [CK__PhieuNhan__SoTie__2B0A656D]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__3864608B]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__3864608B]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__3864608B]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
ALTER TABLE [dbo].[PhieuNhanNoKHCT] DROP CONSTRAINT [CK__PhieuNhan__SoTie__3864608B]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__395884C4]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__395884C4]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__395884C4]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
ALTER TABLE [dbo].[PhieuNhanNoKHCT] DROP CONSTRAINT [CK__PhieuNhan__SoTie__395884C4]

END
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__634EBE90]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__634EBE90]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__634EBE90]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [CK__PhieuNhan__KyHan__634EBE90]

END
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__65370702]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__65370702]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__65370702]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [CK__PhieuNhan__KyHan__65370702]

END
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__671F4F74]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__671F4F74]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__671F4F74]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [CK__PhieuNhan__KyHan__671F4F74]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__5CA1C101]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__5CA1C101]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__5CA1C101]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [CK__PhieuNhan__SoTie__5CA1C101]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__5E8A0973]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__5E8A0973]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__5E8A0973]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [CK__PhieuNhan__SoTie__5E8A0973]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__607251E5]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__607251E5]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__607251E5]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [CK__PhieuNhan__SoTie__607251E5]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__6DCC4D03]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__6DCC4D03]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__6DCC4D03]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
ALTER TABLE [dbo].[PhieuNhanNoNCCCT] DROP CONSTRAINT [CK__PhieuNhan__SoTie__6DCC4D03]

END
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__6EC0713C]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__6EC0713C]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__6EC0713C]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
ALTER TABLE [dbo].[PhieuNhanNoNCCCT] DROP CONSTRAINT [CK__PhieuNhan__SoTie__6EC0713C]

END
GO
/****** Object:  Check [CK__PhieuThu__SoTien__1BC821DD]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuThu__SoTien__1BC821DD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
BEGIN
IF  EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuThu__SoTien__1BC821DD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
ALTER TABLE [dbo].[PhieuThu] DROP CONSTRAINT [CK__PhieuThu__SoTien__1BC821DD]

END
GO
/****** Object:  Default [DF__GiaoDichK__SoTie__1CF15040]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichK__SoTie__1CF15040]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
Begin
ALTER TABLE [dbo].[GiaoDichKH] DROP CONSTRAINT [DF__GiaoDichK__SoTie__1CF15040]

End
GO
/****** Object:  Default [DF__GiaoDichK__SoTie__1ED998B2]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichK__SoTie__1ED998B2]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
Begin
ALTER TABLE [dbo].[GiaoDichKH] DROP CONSTRAINT [DF__GiaoDichK__SoTie__1ED998B2]

End
GO
/****** Object:  Default [DF__GiaoDichK__SoTie__20C1E124]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichK__SoTie__20C1E124]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
Begin
ALTER TABLE [dbo].[GiaoDichKH] DROP CONSTRAINT [DF__GiaoDichK__SoTie__20C1E124]

End
GO
/****** Object:  Default [DF__GiaoDichK__TinhT__21B6055D]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichK__TinhT__21B6055D]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
Begin
ALTER TABLE [dbo].[GiaoDichKH] DROP CONSTRAINT [DF__GiaoDichK__TinhT__21B6055D]

End
GO
/****** Object:  Default [DF__GiaoDichN__SoTie__540C7B00]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichN__SoTie__540C7B00]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
Begin
ALTER TABLE [dbo].[GiaoDichNCC] DROP CONSTRAINT [DF__GiaoDichN__SoTie__540C7B00]

End
GO
/****** Object:  Default [DF__GiaoDichN__SoTie__55F4C372]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichN__SoTie__55F4C372]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
Begin
ALTER TABLE [dbo].[GiaoDichNCC] DROP CONSTRAINT [DF__GiaoDichN__SoTie__55F4C372]

End
GO
/****** Object:  Default [DF__GiaoDichN__SoTie__57DD0BE4]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichN__SoTie__57DD0BE4]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
Begin
ALTER TABLE [dbo].[GiaoDichNCC] DROP CONSTRAINT [DF__GiaoDichN__SoTie__57DD0BE4]

End
GO
/****** Object:  Default [DF_GiaoDichNCC_TinhTrang]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_GiaoDichNCC_TinhTrang]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
Begin
ALTER TABLE [dbo].[GiaoDichNCC] DROP CONSTRAINT [DF_GiaoDichNCC_TinhTrang]

End
GO
/****** Object:  Default [DF__HanTraLai__KyHan__4F12BBB9]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__HanTraLai__KyHan__4F12BBB9]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]'))
Begin
ALTER TABLE [dbo].[HanTraLaiKH] DROP CONSTRAINT [DF__HanTraLai__KyHan__4F12BBB9]

End
GO
/****** Object:  Default [DF__HanTraLai__KyHan__589C25F3]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__HanTraLai__KyHan__589C25F3]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]'))
Begin
ALTER TABLE [dbo].[HanTraLaiNCC] DROP CONSTRAINT [DF__HanTraLai__KyHan__589C25F3]

End
GO
/****** Object:  Default [DF__HanTraNoK__KyHan__53D770D6]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__HanTraNoK__KyHan__53D770D6]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]'))
Begin
ALTER TABLE [dbo].[HanTraNoKH] DROP CONSTRAINT [DF__HanTraNoK__KyHan__53D770D6]

End
GO
/****** Object:  Default [DF__HanTraNoN__KyHan__5D60DB10]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__HanTraNoN__KyHan__5D60DB10]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]'))
Begin
ALTER TABLE [dbo].[HanTraNoNCC] DROP CONSTRAINT [DF__HanTraNoN__KyHan__5D60DB10]

End
GO
/****** Object:  Default [DF_LoaiPhieu_ChiSoTruoc]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_LoaiPhieu_ChiSoTruoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[LoaiPhieu]'))
Begin
ALTER TABLE [dbo].[LoaiPhieu] DROP CONSTRAINT [DF_LoaiPhieu_ChiSoTruoc]

End
GO
/****** Object:  Default [DF_NhanVien_GioiTinh]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_NhanVien_GioiTinh]') AND parent_object_id = OBJECT_ID(N'[dbo].[NhanVien]'))
Begin
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [DF_NhanVien_GioiTinh]

End
GO
/****** Object:  Default [DF__PhieuChi__TinhTr__22751F6C]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuChi__TinhTr__22751F6C]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
Begin
ALTER TABLE [dbo].[PhieuChi] DROP CONSTRAINT [DF__PhieuChi__TinhTr__22751F6C]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__282DF8C2]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__282DF8C2]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__SoTie__282DF8C2]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__2A164134]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__2A164134]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__SoTie__2A164134]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__2BFE89A6]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__2BFE89A6]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__SoTie__2BFE89A6]

End
GO
/****** Object:  Default [DF__PhieuNhan__LaiSu__2CF2ADDF]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__LaiSu__2CF2ADDF]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__LaiSu__2CF2ADDF]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__2EDAF651]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__2EDAF651]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__KyHan__2EDAF651]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__30C33EC3]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__30C33EC3]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__KyHan__30C33EC3]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__32AB8735]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__32AB8735]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__KyHan__32AB8735]

End
GO
/****** Object:  Default [DF__PhieuNhan__PhatQ__339FAB6E]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__PhatQ__339FAB6E]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__PhatQ__339FAB6E]

End
GO
/****** Object:  Default [DF__PhieuNhan__TinhT__3493CFA7]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__TinhT__3493CFA7]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] DROP CONSTRAINT [DF__PhieuNhan__TinhT__3493CFA7]

End
GO
/****** Object:  Default [DF__PhieuNhan__TinhT__3A4CA8FD]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__TinhT__3A4CA8FD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKHCT] DROP CONSTRAINT [DF__PhieuNhan__TinhT__3A4CA8FD]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__5D95E53A]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__5D95E53A]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__SoTie__5D95E53A]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__5F7E2DAC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__5F7E2DAC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__SoTie__5F7E2DAC]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__6166761E]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__6166761E]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__SoTie__6166761E]

End
GO
/****** Object:  Default [DF__PhieuNhan__LaiSu__625A9A57]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__LaiSu__625A9A57]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__LaiSu__625A9A57]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__6442E2C9]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__6442E2C9]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__KyHan__6442E2C9]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__662B2B3B]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__662B2B3B]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__KyHan__662B2B3B]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__681373AD]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__681373AD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__KyHan__681373AD]

End
GO
/****** Object:  Default [DF__PhieuNhan__PhatQ__690797E6]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__PhatQ__690797E6]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__PhatQ__690797E6]

End
GO
/****** Object:  Default [DF__PhieuNhan__TinhT__69FBBC1F]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__TinhT__69FBBC1F]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] DROP CONSTRAINT [DF__PhieuNhan__TinhT__69FBBC1F]

End
GO
/****** Object:  Default [DF__PhieuThu__TinhTr__1CBC4616]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuThu__TinhTr__1CBC4616]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
Begin
ALTER TABLE [dbo].[PhieuThu] DROP CONSTRAINT [DF__PhieuThu__TinhTr__1CBC4616]

End
GO
/****** Object:  Default [DF__QuyDinh__LichSao__114A936A]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__QuyDinh__LichSao__114A936A]') AND parent_object_id = OBJECT_ID(N'[dbo].[QuyDinh]'))
Begin
ALTER TABLE [dbo].[QuyDinh] DROP CONSTRAINT [DF__QuyDinh__LichSao__114A936A]

End
GO
/****** Object:  Default [DF__QuyDinh__TimKiem__123EB7A3]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__QuyDinh__TimKiem__123EB7A3]') AND parent_object_id = OBJECT_ID(N'[dbo].[QuyDinh]'))
Begin
ALTER TABLE [dbo].[QuyDinh] DROP CONSTRAINT [DF__QuyDinh__TimKiem__123EB7A3]

End
GO
/****** Object:  Default [DF__QuyDinh__TaiKhoa__1332DBDC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__QuyDinh__TaiKhoa__1332DBDC]') AND parent_object_id = OBJECT_ID(N'[dbo].[QuyDinh]'))
Begin
ALTER TABLE [dbo].[QuyDinh] DROP CONSTRAINT [DF__QuyDinh__TaiKhoa__1332DBDC]

End
GO
/****** Object:  StoredProcedure [dbo].[Delete_PhieuChi]    Script Date: 04/10/2012 12:48:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Delete_PhieuChi]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Delete_PhieuChi]
GO
/****** Object:  StoredProcedure [dbo].[Delete_PhieuThu]    Script Date: 04/10/2012 12:48:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Delete_PhieuThu]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Delete_PhieuThu]
GO
/****** Object:  StoredProcedure [dbo].[Update_PhieuThu]    Script Date: 04/10/2012 12:48:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Update_PhieuThu]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Update_PhieuThu]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PhieuChi]    Script Date: 04/10/2012 12:48:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Insert_PhieuChi]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Insert_PhieuChi]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PhieuThu]    Script Date: 04/10/2012 12:48:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Insert_PhieuThu]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Insert_PhieuThu]
GO
/****** Object:  StoredProcedure [dbo].[XacNhan_PhieuChi]    Script Date: 04/10/2012 12:48:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[XacNhan_PhieuChi]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[XacNhan_PhieuChi]
GO
/****** Object:  StoredProcedure [dbo].[XacNhan_PhieuThu]    Script Date: 04/10/2012 12:48:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[XacNhan_PhieuThu]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[XacNhan_PhieuThu]
GO
/****** Object:  StoredProcedure [dbo].[Update_PhieuChi]    Script Date: 04/10/2012 12:48:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Update_PhieuChi]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Update_PhieuChi]
GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuThu]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuThu]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NguoiDung]') AND type in (N'U'))
DROP TABLE [dbo].[NguoiDung]
GO
/****** Object:  Table [dbo].[PhieuNhanNoNCCCT]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuNhanNoNCCCT]
GO
/****** Object:  Table [dbo].[HanTraNoNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]') AND type in (N'U'))
DROP TABLE [dbo].[HanTraNoNCC]
GO
/****** Object:  Table [dbo].[HanTraLaiNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]') AND type in (N'U'))
DROP TABLE [dbo].[HanTraLaiNCC]
GO
/****** Object:  Table [dbo].[PhieuNhanNoNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuNhanNoNCC]
GO
/****** Object:  Table [dbo].[GiaoDichNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]') AND type in (N'U'))
DROP TABLE [dbo].[GiaoDichNCC]
GO
/****** Object:  Table [dbo].[HanTraNoKH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]') AND type in (N'U'))
DROP TABLE [dbo].[HanTraNoKH]
GO
/****** Object:  Table [dbo].[HanTraLaiKH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]') AND type in (N'U'))
DROP TABLE [dbo].[HanTraLaiKH]
GO
/****** Object:  Table [dbo].[PhieuNhanNoKHCT]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuNhanNoKHCT]
GO
/****** Object:  Table [dbo].[PhieuNhanNoKH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuNhanNoKH]
GO
/****** Object:  Table [dbo].[GiaoDichKH]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]') AND type in (N'U'))
DROP TABLE [dbo].[GiaoDichKH]
GO
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuChi]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuChi]
GO
/****** Object:  Table [dbo].[KhoanThu]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhoanThu]') AND type in (N'U'))
DROP TABLE [dbo].[KhoanThu]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhaCungCap]') AND type in (N'U'))
DROP TABLE [dbo].[NhaCungCap]
GO
/****** Object:  Table [dbo].[LoaiPhieu]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiPhieu]') AND type in (N'U'))
DROP TABLE [dbo].[LoaiPhieu]
GO
/****** Object:  Table [dbo].[LoaiNguoiDung]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiNguoiDung]') AND type in (N'U'))
DROP TABLE [dbo].[LoaiNguoiDung]
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuyDinh]') AND type in (N'U'))
DROP TABLE [dbo].[QuyDinh]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[KhoanChi]    Script Date: 04/10/2012 12:48:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhoanChi]') AND type in (N'U'))
DROP TABLE [dbo].[KhoanChi]
GO
/****** Object:  Table [dbo].[KhoanChi]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhoanChi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KhoanChi](
	[MaKC] [int] IDENTITY(1,1) NOT NULL,
	[TenKC] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[GhiChu] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__KhoanChi__023D5A04] PRIMARY KEY CLUSTERED 
(
	[MaKC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[KhoanChi] ON
INSERT [dbo].[KhoanChi] ([MaKC], [TenKC], [GhiChu]) VALUES (1, N'Trả lương', N'')
INSERT [dbo].[KhoanChi] ([MaKC], [TenKC], [GhiChu]) VALUES (2, N'Trả tiền internet', NULL)
INSERT [dbo].[KhoanChi] ([MaKC], [TenKC], [GhiChu]) VALUES (3, N'Tiếp khách', NULL)
INSERT [dbo].[KhoanChi] ([MaKC], [TenKC], [GhiChu]) VALUES (4, N'Công việc', N'')
SET IDENTITY_INSERT [dbo].[KhoanChi] OFF
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenNV] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[CMND] [varchar](11) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DiaChi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DienThoai] [varchar](11) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__NhanVien__0425A276] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DienThoai]) VALUES (N'NV001', N'Vũ Thị Chinh', CAST(0x000079DE00000000 AS DateTime), 1, N'0987583159', N'72 Lạch Tray', N'0987583159')
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuyDinh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[QuyDinh](
	[TenCongTy] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DiaChi] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DienThoai] [varchar](11) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LichSaoLuu] [int] NULL,
	[ThoiDiemSaoLuuTiepTheo] [datetime] NULL,
	[ViTriSaoLuu] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TimKiemTuDong] [bit] NULL,
	[TaiKhoanCo] [bigint] NULL
)
END
GO
INSERT [dbo].[QuyDinh] ([TenCongTy], [DiaChi], [DienThoai], [LichSaoLuu], [ThoiDiemSaoLuuTiepTheo], [ViTriSaoLuu], [TimKiemTuDong], [TaiKhoanCo]) VALUES (N'Công ty TNHH đầu tư và phát triển thương mại Ngọc Minh', N'48/633 Thiên Lôi - Lê Chân - Hải Phòng', N'09853258885', 27, CAST(0x0000A03F009F46E0 AS DateTime), N'E:\MyDatabase\NgocMinh-Database', 1, 2250000)
/****** Object:  Table [dbo].[LoaiNguoiDung]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiNguoiDung]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoaiNguoiDung](
	[MaLoaiNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiNguoiDung] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__LoaiNguoiDung__603D47BB] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNguoiDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[LoaiNguoiDung] ON
INSERT [dbo].[LoaiNguoiDung] ([MaLoaiNguoiDung], [TenLoaiNguoiDung]) VALUES (1, N'Quản trị viên')
INSERT [dbo].[LoaiNguoiDung] ([MaLoaiNguoiDung], [TenLoaiNguoiDung]) VALUES (2, N'Nhân viên giao dịch')
SET IDENTITY_INSERT [dbo].[LoaiNguoiDung] OFF
/****** Object:  Table [dbo].[LoaiPhieu]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiPhieu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoaiPhieu](
	[MaLoaiPhieu] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhieu] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SoPhieuTruoc] [int] NULL,
 CONSTRAINT [PK__LoaiPhieu__72C60C4A] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[LoaiPhieu] ON
INSERT [dbo].[LoaiPhieu] ([MaLoaiPhieu], [TenLoaiPhieu], [SoPhieuTruoc]) VALUES (1, N'Phiếu nhận nợ chi tiết khách hàng', 0)
INSERT [dbo].[LoaiPhieu] ([MaLoaiPhieu], [TenLoaiPhieu], [SoPhieuTruoc]) VALUES (2, N'Phiếu thanh toán nợ  khách hàng', 0)
INSERT [dbo].[LoaiPhieu] ([MaLoaiPhieu], [TenLoaiPhieu], [SoPhieuTruoc]) VALUES (3, N'Phiếu thanh toán lãi khách hàng', 0)
INSERT [dbo].[LoaiPhieu] ([MaLoaiPhieu], [TenLoaiPhieu], [SoPhieuTruoc]) VALUES (4, N'Phiếu nhận nợ chi tiết nhà cung cấp', 0)
INSERT [dbo].[LoaiPhieu] ([MaLoaiPhieu], [TenLoaiPhieu], [SoPhieuTruoc]) VALUES (5, N'Phiếu thanh toán nợ nhà cung cấp', 0)
INSERT [dbo].[LoaiPhieu] ([MaLoaiPhieu], [TenLoaiPhieu], [SoPhieuTruoc]) VALUES (6, N'Phiếu thanh toán lãi nhà cung cấp', 0)
SET IDENTITY_INSERT [dbo].[LoaiPhieu] OFF
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhaCungCap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenNCC] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DiaChi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DienThoai] [varchar](11) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__NhaCungCap__7C8480AE] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai]) VALUES (N'NCC01', N'ACB', N'Hải Phòng', N'0313525825')
/****** Object:  Table [dbo].[KhachHang]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenKH] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DiaChi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DienThoai] [varchar](11) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__KhachHang__76CBA758] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai]) VALUES (N'KH001', N'Vũ Đình Trung', N'Sở Dầu, Hồng Bàng', N'01266489233')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai]) VALUES (N'KH002', N'Vũ Văn Nam', N'Hùng Vương, Hồng Bàng. Hải Phòng', N'01266489233')
/****** Object:  Table [dbo].[KhoanThu]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhoanThu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KhoanThu](
	[MaKT] [int] IDENTITY(1,1) NOT NULL,
	[TenKT] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[GhiChu] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__KhoanThu__7E6CC920] PRIMARY KEY CLUSTERED 
(
	[MaKT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[KhoanThu] ON
INSERT [dbo].[KhoanThu] ([MaKT], [TenKT], [GhiChu]) VALUES (1, N'Phí dịch vụ ngân hàng', N'')
INSERT [dbo].[KhoanThu] ([MaKT], [TenKT], [GhiChu]) VALUES (2, N'Nhập quỹ', N'')
INSERT [dbo].[KhoanThu] ([MaKT], [TenKT], [GhiChu]) VALUES (3, N'Dịch vụ tư vấn nhà đất', N'')
INSERT [dbo].[KhoanThu] ([MaKT], [TenKT], [GhiChu]) VALUES (4, N'Dịch vụ cafe', N'')
SET IDENTITY_INSERT [dbo].[KhoanThu] OFF
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuChi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhieuChi](
	[SoPC] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[NgayChi] [datetime] NULL,
	[MaKC] [int] NOT NULL,
	[SoTienChi] [bigint] NOT NULL,
	[Ton] [bigint] NULL,
	[GhiChu] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TinhTrang] [bit] NULL,
	[DuTru] [bigint] NULL,
 CONSTRAINT [PK__PhieuChi__208CD6FA] PRIMARY KEY CLUSTERED 
(
	[SoPC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PhieuChi] ON
INSERT [dbo].[PhieuChi] ([SoPC], [MaNV], [NgayLap], [NgayChi], [MaKC], [SoTienChi], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (1, N'NV001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 2, 1250000, 0, N'asdf', 0, NULL)
INSERT [dbo].[PhieuChi] ([SoPC], [MaNV], [NgayLap], [NgayChi], [MaKC], [SoTienChi], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (2, N'NV001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 1, 1250000, 3750000, N'asdf', 1, NULL)
INSERT [dbo].[PhieuChi] ([SoPC], [MaNV], [NgayLap], [NgayChi], [MaKC], [SoTienChi], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (3, N'NV001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 1, 1250000, 2500000, N'asdf', 1, NULL)
INSERT [dbo].[PhieuChi] ([SoPC], [MaNV], [NgayLap], [NgayChi], [MaKC], [SoTienChi], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (4, N'NV001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 1, 1250000, 1250000, N'asdf', 1, NULL)
SET IDENTITY_INSERT [dbo].[PhieuChi] OFF
/****** Object:  Table [dbo].[GiaoDichKH]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GiaoDichKH](
	[MaGD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [varchar](5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgayBatDauGD] [datetime] NULL,
	[SoTienVay] [bigint] NULL,
	[SoTienConNo] [bigint] NULL,
	[SoTienLaiDaTra] [bigint] NULL,
	[GhiChu] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK__GiaoDichKH__1B0907CE] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[PhieuNhanNoKH]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhieuNhanNoKH](
	[SoPhieuNhanNo] [int] IDENTITY(1,1) NOT NULL,
	[MaGD] [int] NOT NULL,
	[NgayBatDauNhanNo] [datetime] NULL,
	[SoTienVay] [bigint] NULL,
	[SoTienConNo] [bigint] NULL,
	[SoTienLaiDaTra] [bigint] NULL,
	[LyDoVay] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LaiSuat] [tinyint] NULL,
	[KyHanNo] [int] NULL,
	[KyHanLai] [int] NULL,
	[NgayTraLaiTiepTheo] [datetime] NULL,
	[KyHanThongBao] [int] NULL,
	[PhatQuaHan] [bit] NULL,
	[TinhTrang] [bit] NULL,
	[SoPhieuNhanNoKHCTCuoi] [int] NULL,
 CONSTRAINT [PK__PhieuNhanNoKH__2645B050] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhanNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[PhieuNhanNoKHCT]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhieuNhanNoKHCT](
	[SoPhieuNhanNoCT] [int] IDENTITY(1,1) NOT NULL,
	[SoPhieuNhanNo] [int] NOT NULL,
	[SoPhieu] [int] NOT NULL,
	[MaLoaiPhieu] [int] NOT NULL,
	[NgayLapPhieu] [datetime] NOT NULL,
	[NgayGiaoDich] [datetime] NULL,
	[SoTienVay] [bigint] NULL,
	[SoTienTra] [bigint] NULL,
	[SoTienTinhLai] [bigint] NULL,
	[SoPhieuNhanNoKHCTTiep] [int] NULL,
	[TienLai] [bigint] NULL,
	[Ton] [bigint] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK__PhieuNhanNoKHCT__37703C52] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhanNoCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[HanTraLaiKH]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HanTraLaiKH](
	[MaHanTraLai] [int] IDENTITY(1,1) NOT NULL,
	[SoPhieuNhanNo] [int] NOT NULL,
	[NgayThayDoi] [timestamp] NULL,
	[KyHanLai] [int] NULL,
	[NgayTraLaiTiepTheo] [datetime] NULL,
 CONSTRAINT [PK__HanTraLaiKH__4D2A7347] PRIMARY KEY CLUSTERED 
(
	[MaHanTraLai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[HanTraNoKH]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HanTraNoKH](
	[MaHanTraNo] [int] IDENTITY(1,1) NOT NULL,
	[SoPhieuNhanNo] [int] NOT NULL,
	[NgayThayDoi] [timestamp] NULL,
	[KyHanNo] [int] NULL,
 CONSTRAINT [PK__HanTraNoKH__51EF2864] PRIMARY KEY CLUSTERED 
(
	[MaHanTraNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[GiaoDichNCC]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GiaoDichNCC](
	[MaGD] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [varchar](5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgayBatDauGD] [datetime] NULL,
	[SoTienVay] [bigint] NULL,
	[SoTienConNo] [bigint] NULL,
	[SoTienLaiDaTra] [bigint] NULL,
	[GhiChu] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK__GiaoDichNCC__5224328E] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[PhieuNhanNoNCC]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhieuNhanNoNCC](
	[SoPhieuNhanNo] [int] IDENTITY(1,1) NOT NULL,
	[MaGD] [int] NOT NULL,
	[NgayBatDauNhanNo] [datetime] NULL,
	[SoTienVay] [bigint] NULL,
	[SoTienConNo] [bigint] NULL,
	[SoTienLaiDaTra] [bigint] NULL,
	[LyDoVay] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LaiSuat] [tinyint] NULL,
	[KyHanNo] [int] NULL,
	[KyHanLai] [int] NULL,
	[NgayTraLaiTiepTheo] [datetime] NULL,
	[KyHanThongBao] [int] NULL,
	[PhatQuaHan] [bit] NULL,
	[TinhTrang] [bit] NULL,
	[SoPhieuNhanNoNCCCTCuoi] [int] NULL,
 CONSTRAINT [PK__PhieuNhanNoNCC__5BAD9CC8] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhanNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[HanTraLaiNCC]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HanTraLaiNCC](
	[MaHanTraLai] [int] IDENTITY(1,1) NOT NULL,
	[SoPhieuNhanNo] [int] NOT NULL,
	[NgayThayDoi] [timestamp] NULL,
	[KyHanLai] [int] NULL,
	[NgayTraLaiTiepTheo] [datetime] NULL,
 CONSTRAINT [PK__HanTraLaiNCC__56B3DD81] PRIMARY KEY CLUSTERED 
(
	[MaHanTraLai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[HanTraNoNCC]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HanTraNoNCC](
	[MaHanTraNo] [int] IDENTITY(1,1) NOT NULL,
	[SoPhieuNhanNo] [int] NOT NULL,
	[NgayThayDoi] [timestamp] NULL,
	[KyHanNo] [int] NULL,
 CONSTRAINT [PK__HanTraNoNCC__5B78929E] PRIMARY KEY CLUSTERED 
(
	[MaHanTraNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[PhieuNhanNoNCCCT]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhieuNhanNoNCCCT](
	[SoPhieuNhanNoCT] [int] IDENTITY(1,1) NOT NULL,
	[SoPhieuNhanNo] [int] NOT NULL,
	[SoPhieu] [int] NOT NULL,
	[MaLoaiPhieu] [int] NOT NULL,
	[NgayLapPhieu] [datetime] NOT NULL,
	[NgayGiaoDich] [datetime] NULL,
	[SoTienVay] [bigint] NULL,
	[SoTienTra] [bigint] NULL,
	[SoTienTinhLai] [bigint] NULL,
	[SoPhieuNhanNoKHCTTiep] [int] NULL,
	[TienLai] [bigint] NULL,
	[Ton] [bigint] NULL,
 CONSTRAINT [PK__PhieuNhanNoNCCCT__6CD828CA] PRIMARY KEY CLUSTERED 
(
	[SoPhieuNhanNoCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NguoiDung]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiNguoiDung] [int] NOT NULL,
	[TenDangNhap] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MatKhau] [varchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenNguoiDung] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__NguoiDung__6225902D] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (1, 1, N'admin', N'UHgbEZ3jDVA=', N'Vũ Đình Trung')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (2, 1, N'vuduc', N'UHgbEZ3jDVA=', N'Vũ Minh Đức')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (3, 2, N'chinh', N'wBNLtHTSQeA=', N'Vũ Thị Chinh')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (4, 2, N'trang', N'wBNLtHTSQeA=', N'Vũ Thị Trang')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (5, 1, N'phuong', N'a1dnEheWohw=', N'Phương')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (6, 1, N'huyvd', N'hj6yTnglpxs=', N'Vũ Đình Huy')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (8, 2, N'hai', N'wBNLtHTSQeA=', N'Vũ Đình Hải')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (9, 2, N'huong', N'LzU8UyvRvGY=', N'Hương')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [MaLoaiNguoiDung], [TenDangNhap], [MatKhau], [TenNguoiDung]) VALUES (10, 2, N'hoangtan', N'LzU8UyvRvGY=', N'Hoàng Văn Tân')
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 04/10/2012 12:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuThu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhieuThu](
	[SoPT] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [varchar](5) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[NgayThu] [datetime] NULL,
	[MaKT] [int] NOT NULL,
	[SoTienThu] [bigint] NOT NULL,
	[Ton] [bigint] NULL,
	[GhiChu] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TinhTrang] [bit] NULL,
	[DuTru] [bigint] NULL,
 CONSTRAINT [PK__PhieuThu__1AD3FDA4] PRIMARY KEY CLUSTERED 
(
	[SoPT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PhieuThu] ON
INSERT [dbo].[PhieuThu] ([SoPT], [MaKH], [NgayLap], [NgayThu], [MaKT], [SoTienThu], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (1, N'KH001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 1, 1250000, 1250000, N'asdf', 1, NULL)
INSERT [dbo].[PhieuThu] ([SoPT], [MaKH], [NgayLap], [NgayThu], [MaKT], [SoTienThu], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (2, N'KH001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 1, 1250000, 1250000, N'asdf', 1, NULL)
INSERT [dbo].[PhieuThu] ([SoPT], [MaKH], [NgayLap], [NgayThu], [MaKT], [SoTienThu], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (3, N'KH001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 1, 1250000, 2500000, N'asdf', 1, NULL)
INSERT [dbo].[PhieuThu] ([SoPT], [MaKH], [NgayLap], [NgayThu], [MaKT], [SoTienThu], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (4, N'KH001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 1, 1250000, 3750000, N'asdf', 1, NULL)
INSERT [dbo].[PhieuThu] ([SoPT], [MaKH], [NgayLap], [NgayThu], [MaKT], [SoTienThu], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (5, N'KH001', CAST(0x0000A0E000000000 AS DateTime), CAST(0x0000A0E000000000 AS DateTime), 1, 1250000, 5000000, N'asdf', 1, NULL)
INSERT [dbo].[PhieuThu] ([SoPT], [MaKH], [NgayLap], [NgayThu], [MaKT], [SoTienThu], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (6, N'KH001', CAST(0x0000A02F0087355F AS DateTime), CAST(0x0000A03000873480 AS DateTime), 1, 1000000, 2250000, N'Thu phí dịch vụ tư vấn vay tiền ngân hàng', 1, NULL)
INSERT [dbo].[PhieuThu] ([SoPT], [MaKH], [NgayLap], [NgayThu], [MaKT], [SoTienThu], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (8, N'KH001', CAST(0x0000A02F00B15EA4 AS DateTime), CAST(0x0000A03000B15EA4 AS DateTime), 2, 1000000, 0, N'Nhập quỹ tháng 4', 0, NULL)
INSERT [dbo].[PhieuThu] ([SoPT], [MaKH], [NgayLap], [NgayThu], [MaKT], [SoTienThu], [Ton], [GhiChu], [TinhTrang], [DuTru]) VALUES (9, N'KH001', CAST(0x0000A02F00BF5C6E AS DateTime), CAST(0x0000A02F00BF5C6E AS DateTime), 1, 1, 0, N'', 0, NULL)
SET IDENTITY_INSERT [dbo].[PhieuThu] OFF
/****** Object:  StoredProcedure [dbo].[Update_PhieuChi]    Script Date: 04/10/2012 12:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Update_PhieuChi]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Update_PhieuChi]
(
	@SoPC int,
	@MaNV varchar(5),
	@NgayLap datetime,
	@NgayChi datetime,
	@MaKC int,
	@SoTienChi bigint,
	@GhiChu ntext,
	@TinhTrang bit
)
AS
BEGIN
	DECLARE @TinhTrangCu bit
	SELECT @TinhTrangCu = TinhTrang FROM PhieuChi WHERE SoPC = @SoPC
	IF @TinhTrangCu=0
	BEGIN
		DECLARE @TaiKhoanCo bigint
		SET @TaiKhoanCo=0
		IF @TinhTrang=1
		BEGIN
			SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
			SET @TaiKhoanCo=@TaiKhoanCo-@SoTienChi
			UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
		END
		UPDATE PhieuChi SET MaNV = @MaNV, NgayLap = @NgayLap,NgayChi = @NgayChi,MaKC = @MaKC,
			SoTienChi = @SoTienChi,GhiChu = @GhiChu,Ton = @TaiKhoanCo,TinhTrang = @TinhTrang
		WHERE SoPC = @SoPC
	END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[XacNhan_PhieuThu]    Script Date: 04/10/2012 12:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[XacNhan_PhieuThu]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[XacNhan_PhieuThu]
(
	@SoPT int
)
AS
BEGIN
	DECLARE @TinhTrangCu bit
	SELECT @TinhTrangCu = TinhTrang FROM PhieuThu WHERE SoPT = @SoPT
	IF @TinhTrangCu=0
	BEGIN
		DECLARE @TaiKhoanCo bigint, @SoTienThu bigint
		SET @TaiKhoanCo=0
		SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
		SELECT @SoTienThu=SoTienThu FROM PhieuThu WHERE SoPT=@SoPT
		SET @TaiKhoanCo=@TaiKhoanCo+@SoTienThu
		UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
		UPDATE PhieuThu SET Ton = @TaiKhoanCo,TinhTrang = 1
		WHERE SoPT = @SoPT
	END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[XacNhan_PhieuChi]    Script Date: 04/10/2012 12:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[XacNhan_PhieuChi]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[XacNhan_PhieuChi]
(
	@SoPC int
)
AS
BEGIN
	DECLARE @TinhTrangCu bit
	SELECT @TinhTrangCu = TinhTrang FROM PhieuChi WHERE SoPC = @SoPC
	IF @TinhTrangCu=0
	BEGIN
		DECLARE @TaiKhoanCo bigint, @SoTienChi bigint
		SET @TaiKhoanCo=0
		SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
		SELECT @SoTienChi=SoTienChi FROM PhieuChi WHERE SoPC=@SoPC
		SET @TaiKhoanCo=@TaiKhoanCo+@SoTienChi
		UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
		UPDATE PhieuChi SET Ton = @TaiKhoanCo,TinhTrang = 1
		WHERE SoPC = @SoPC
	END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_PhieuThu]    Script Date: 04/10/2012 12:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Insert_PhieuThu]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Insert_PhieuThu]
(
	@SoPT int OUTPUT,
	@MaKH varchar(5),
	@NgayLap datetime,
	@NgayThu datetime,
	@MaKT int,
	@SoTienThu bigint,
	@GhiChu ntext,
	@TinhTrang bit
)
AS
BEGIN
	DECLARE @TaiKhoanCo bigint
	SET @TaiKhoanCo=0
	IF @TinhTrang=1
	BEGIN
		SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
		SET @TaiKhoanCo=@TaiKhoanCo+@SoTienThu
		UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
	END
	INSERT INTO PhieuThu(MaKH,NgayLap,NgayThu,MaKT,SoTienThu,GhiChu,Ton,TinhTrang) 
	Values (@MaKH, @NgayLap, @NgayThu, @MaKT, @SoTienThu,@GhiChu, @TaiKhoanCo,@TinhTrang)
	SET @SoPT = SCOPE_IDENTITY()
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_PhieuChi]    Script Date: 04/10/2012 12:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Insert_PhieuChi]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Insert_PhieuChi]
(
	@SoPC int OUTPUT,
	@MaNV varchar(5),
	@NgayLap datetime,
	@NgayChi datetime,
	@MaKC int,
	@SoTienChi bigint,
	@GhiChu ntext,
	@TinhTrang bit
)
AS
BEGIN
	DECLARE @TaiKhoanCo bigint
	SET @TaiKhoanCo=0
	IF @TinhTrang=1
	BEGIN
		SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
		SET @TaiKhoanCo=@TaiKhoanCo-@SoTienChi
		UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
	END
	INSERT INTO PhieuChi(MaNV,NgayLap,NgayChi,MaKC,SoTienChi,GhiChu,Ton,TinhTrang) 
	Values (@MaNV, @NgayLap, @NgayChi, @MaKC, @SoTienChi,@GhiChu, @TaiKhoanCo,@TinhTrang)
	SET @SoPC = SCOPE_IDENTITY()
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[Update_PhieuThu]    Script Date: 04/10/2012 12:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Update_PhieuThu]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Update_PhieuThu]
(
	@SoPT int,
	@MaKH varchar(5),
	@NgayLap datetime,
	@NgayThu datetime,
	@MaKT int,
	@SoTienThu bigint,
	@GhiChu ntext,
	@TinhTrang bit
)
AS
BEGIN
	DECLARE @TinhTrangCu bit
	SELECT @TinhTrangCu = TinhTrang FROM PhieuThu WHERE SoPT = @SoPT
	IF @TinhTrangCu=0
	BEGIN
		DECLARE @TaiKhoanCo bigint
		SET @TaiKhoanCo=0
		IF @TinhTrang=1
		BEGIN
			SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
			SET @TaiKhoanCo=@TaiKhoanCo+@SoTienThu
			UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
		END
		UPDATE PhieuThu SET MaKH = @MaKH, NgayLap = @NgayLap,NgayThu = @NgayThu,MaKT = @MaKT,
			SoTienThu = @SoTienThu,GhiChu = @GhiChu,Ton = @TaiKhoanCo,TinhTrang = @TinhTrang
		WHERE SoPT = @SoPT
	END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_PhieuThu]    Script Date: 04/10/2012 12:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Delete_PhieuThu]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Delete_PhieuThu]
(
	@SoPT int
)
AS
BEGIN
	DECLARE @TinhTrang bit
	SELECT @TinhTrang = TinhTrang FROM PhieuThu WHERE SoPT = @SoPT
	IF @TinhTrang=0
		DELETE FROM PhieuThu WHERE SoPT = @SoPT
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[Delete_PhieuChi]    Script Date: 04/10/2012 12:48:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Delete_PhieuChi]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Delete_PhieuChi]
(
	@SoPC int
)
AS
BEGIN
	DECLARE @TinhTrang bit
	SELECT @TinhTrang = TinhTrang FROM PhieuChi WHERE SoPC = @SoPC
	IF @TinhTrang=0
		DELETE FROM PhieuChi WHERE SoPC = @SoPC
END' 
END
GO
/****** Object:  Default [DF__GiaoDichK__SoTie__1CF15040]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichK__SoTie__1CF15040]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
Begin
ALTER TABLE [dbo].[GiaoDichKH] ADD  CONSTRAINT [DF__GiaoDichK__SoTie__1CF15040]  DEFAULT (0) FOR [SoTienVay]

End
GO
/****** Object:  Default [DF__GiaoDichK__SoTie__1ED998B2]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichK__SoTie__1ED998B2]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
Begin
ALTER TABLE [dbo].[GiaoDichKH] ADD  CONSTRAINT [DF__GiaoDichK__SoTie__1ED998B2]  DEFAULT (0) FOR [SoTienConNo]

End
GO
/****** Object:  Default [DF__GiaoDichK__SoTie__20C1E124]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichK__SoTie__20C1E124]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
Begin
ALTER TABLE [dbo].[GiaoDichKH] ADD  CONSTRAINT [DF__GiaoDichK__SoTie__20C1E124]  DEFAULT (0) FOR [SoTienLaiDaTra]

End
GO
/****** Object:  Default [DF__GiaoDichK__TinhT__21B6055D]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichK__TinhT__21B6055D]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
Begin
ALTER TABLE [dbo].[GiaoDichKH] ADD  CONSTRAINT [DF__GiaoDichK__TinhT__21B6055D]  DEFAULT (0) FOR [TinhTrang]

End
GO
/****** Object:  Default [DF__GiaoDichN__SoTie__540C7B00]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichN__SoTie__540C7B00]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
Begin
ALTER TABLE [dbo].[GiaoDichNCC] ADD  CONSTRAINT [DF__GiaoDichN__SoTie__540C7B00]  DEFAULT (0) FOR [SoTienVay]

End
GO
/****** Object:  Default [DF__GiaoDichN__SoTie__55F4C372]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichN__SoTie__55F4C372]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
Begin
ALTER TABLE [dbo].[GiaoDichNCC] ADD  CONSTRAINT [DF__GiaoDichN__SoTie__55F4C372]  DEFAULT (0) FOR [SoTienConNo]

End
GO
/****** Object:  Default [DF__GiaoDichN__SoTie__57DD0BE4]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__GiaoDichN__SoTie__57DD0BE4]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
Begin
ALTER TABLE [dbo].[GiaoDichNCC] ADD  CONSTRAINT [DF__GiaoDichN__SoTie__57DD0BE4]  DEFAULT (0) FOR [SoTienLaiDaTra]

End
GO
/****** Object:  Default [DF_GiaoDichNCC_TinhTrang]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_GiaoDichNCC_TinhTrang]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
Begin
ALTER TABLE [dbo].[GiaoDichNCC] ADD  CONSTRAINT [DF_GiaoDichNCC_TinhTrang]  DEFAULT (0) FOR [TinhTrang]

End
GO
/****** Object:  Default [DF__HanTraLai__KyHan__4F12BBB9]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__HanTraLai__KyHan__4F12BBB9]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]'))
Begin
ALTER TABLE [dbo].[HanTraLaiKH] ADD  CONSTRAINT [DF__HanTraLai__KyHan__4F12BBB9]  DEFAULT (1) FOR [KyHanLai]

End
GO
/****** Object:  Default [DF__HanTraLai__KyHan__589C25F3]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__HanTraLai__KyHan__589C25F3]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]'))
Begin
ALTER TABLE [dbo].[HanTraLaiNCC] ADD  CONSTRAINT [DF__HanTraLai__KyHan__589C25F3]  DEFAULT (1) FOR [KyHanLai]

End
GO
/****** Object:  Default [DF__HanTraNoK__KyHan__53D770D6]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__HanTraNoK__KyHan__53D770D6]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]'))
Begin
ALTER TABLE [dbo].[HanTraNoKH] ADD  CONSTRAINT [DF__HanTraNoK__KyHan__53D770D6]  DEFAULT (1) FOR [KyHanNo]

End
GO
/****** Object:  Default [DF__HanTraNoN__KyHan__5D60DB10]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__HanTraNoN__KyHan__5D60DB10]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]'))
Begin
ALTER TABLE [dbo].[HanTraNoNCC] ADD  CONSTRAINT [DF__HanTraNoN__KyHan__5D60DB10]  DEFAULT (1) FOR [KyHanNo]

End
GO
/****** Object:  Default [DF_LoaiPhieu_ChiSoTruoc]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_LoaiPhieu_ChiSoTruoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[LoaiPhieu]'))
Begin
ALTER TABLE [dbo].[LoaiPhieu] ADD  CONSTRAINT [DF_LoaiPhieu_ChiSoTruoc]  DEFAULT (0) FOR [SoPhieuTruoc]

End
GO
/****** Object:  Default [DF_NhanVien_GioiTinh]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_NhanVien_GioiTinh]') AND parent_object_id = OBJECT_ID(N'[dbo].[NhanVien]'))
Begin
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_GioiTinh]  DEFAULT (0) FOR [GioiTinh]

End
GO
/****** Object:  Default [DF__PhieuChi__TinhTr__22751F6C]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuChi__TinhTr__22751F6C]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
Begin
ALTER TABLE [dbo].[PhieuChi] ADD  CONSTRAINT [DF__PhieuChi__TinhTr__22751F6C]  DEFAULT (0) FOR [TinhTrang]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__282DF8C2]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__282DF8C2]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__SoTie__282DF8C2]  DEFAULT (0) FOR [SoTienVay]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__2A164134]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__2A164134]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__SoTie__2A164134]  DEFAULT (0) FOR [SoTienConNo]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__2BFE89A6]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__2BFE89A6]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__SoTie__2BFE89A6]  DEFAULT (0) FOR [SoTienLaiDaTra]

End
GO
/****** Object:  Default [DF__PhieuNhan__LaiSu__2CF2ADDF]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__LaiSu__2CF2ADDF]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__LaiSu__2CF2ADDF]  DEFAULT (0) FOR [LaiSuat]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__2EDAF651]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__2EDAF651]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__KyHan__2EDAF651]  DEFAULT (1) FOR [KyHanNo]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__30C33EC3]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__30C33EC3]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__KyHan__30C33EC3]  DEFAULT (1) FOR [KyHanLai]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__32AB8735]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__32AB8735]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__KyHan__32AB8735]  DEFAULT (1) FOR [KyHanThongBao]

End
GO
/****** Object:  Default [DF__PhieuNhan__PhatQ__339FAB6E]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__PhatQ__339FAB6E]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__PhatQ__339FAB6E]  DEFAULT (0) FOR [PhatQuaHan]

End
GO
/****** Object:  Default [DF__PhieuNhan__TinhT__3493CFA7]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__TinhT__3493CFA7]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKH] ADD  CONSTRAINT [DF__PhieuNhan__TinhT__3493CFA7]  DEFAULT (0) FOR [TinhTrang]

End
GO
/****** Object:  Default [DF__PhieuNhan__TinhT__3A4CA8FD]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__TinhT__3A4CA8FD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoKHCT] ADD  CONSTRAINT [DF__PhieuNhan__TinhT__3A4CA8FD]  DEFAULT (0) FOR [TinhTrang]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__5D95E53A]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__5D95E53A]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__SoTie__5D95E53A]  DEFAULT (0) FOR [SoTienVay]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__5F7E2DAC]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__5F7E2DAC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__SoTie__5F7E2DAC]  DEFAULT (0) FOR [SoTienConNo]

End
GO
/****** Object:  Default [DF__PhieuNhan__SoTie__6166761E]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__SoTie__6166761E]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__SoTie__6166761E]  DEFAULT (0) FOR [SoTienLaiDaTra]

End
GO
/****** Object:  Default [DF__PhieuNhan__LaiSu__625A9A57]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__LaiSu__625A9A57]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__LaiSu__625A9A57]  DEFAULT (0) FOR [LaiSuat]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__6442E2C9]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__6442E2C9]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__KyHan__6442E2C9]  DEFAULT (1) FOR [KyHanNo]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__662B2B3B]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__662B2B3B]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__KyHan__662B2B3B]  DEFAULT (1) FOR [KyHanLai]

End
GO
/****** Object:  Default [DF__PhieuNhan__KyHan__681373AD]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__KyHan__681373AD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__KyHan__681373AD]  DEFAULT (1) FOR [KyHanThongBao]

End
GO
/****** Object:  Default [DF__PhieuNhan__PhatQ__690797E6]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__PhatQ__690797E6]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__PhatQ__690797E6]  DEFAULT (0) FOR [PhatQuaHan]

End
GO
/****** Object:  Default [DF__PhieuNhan__TinhT__69FBBC1F]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuNhan__TinhT__69FBBC1F]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
Begin
ALTER TABLE [dbo].[PhieuNhanNoNCC] ADD  CONSTRAINT [DF__PhieuNhan__TinhT__69FBBC1F]  DEFAULT (0) FOR [TinhTrang]

End
GO
/****** Object:  Default [DF__PhieuThu__TinhTr__1CBC4616]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__PhieuThu__TinhTr__1CBC4616]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
Begin
ALTER TABLE [dbo].[PhieuThu] ADD  CONSTRAINT [DF__PhieuThu__TinhTr__1CBC4616]  DEFAULT (0) FOR [TinhTrang]

End
GO
/****** Object:  Default [DF__QuyDinh__LichSao__114A936A]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__QuyDinh__LichSao__114A936A]') AND parent_object_id = OBJECT_ID(N'[dbo].[QuyDinh]'))
Begin
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF__QuyDinh__LichSao__114A936A]  DEFAULT (0) FOR [LichSaoLuu]

End
GO
/****** Object:  Default [DF__QuyDinh__TimKiem__123EB7A3]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__QuyDinh__TimKiem__123EB7A3]') AND parent_object_id = OBJECT_ID(N'[dbo].[QuyDinh]'))
Begin
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF__QuyDinh__TimKiem__123EB7A3]  DEFAULT (1) FOR [TimKiemTuDong]

End
GO
/****** Object:  Default [DF__QuyDinh__TaiKhoa__1332DBDC]    Script Date: 04/10/2012 12:48:54 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__QuyDinh__TaiKhoa__1332DBDC]') AND parent_object_id = OBJECT_ID(N'[dbo].[QuyDinh]'))
Begin
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF__QuyDinh__TaiKhoa__1332DBDC]  DEFAULT (0) FOR [TaiKhoanCo]

End
GO
/****** Object:  Check [CK__GiaoDichK__SoTie__1BFD2C07]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1BFD2C07]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
ALTER TABLE [dbo].[GiaoDichKH]  WITH NOCHECK ADD  CONSTRAINT [CK__GiaoDichK__SoTie__1BFD2C07] CHECK  (([SoTienVay] >= 0))
GO
ALTER TABLE [dbo].[GiaoDichKH] CHECK CONSTRAINT [CK__GiaoDichK__SoTie__1BFD2C07]
GO
/****** Object:  Check [CK__GiaoDichK__SoTie__1DE57479]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1DE57479]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
ALTER TABLE [dbo].[GiaoDichKH]  WITH NOCHECK ADD  CONSTRAINT [CK__GiaoDichK__SoTie__1DE57479] CHECK  (([SoTienConNo] >= 0))
GO
ALTER TABLE [dbo].[GiaoDichKH] CHECK CONSTRAINT [CK__GiaoDichK__SoTie__1DE57479]
GO
/****** Object:  Check [CK__GiaoDichK__SoTie__1FCDBCEB]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichK__SoTie__1FCDBCEB]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
ALTER TABLE [dbo].[GiaoDichKH]  WITH NOCHECK ADD  CONSTRAINT [CK__GiaoDichK__SoTie__1FCDBCEB] CHECK  (([SoTienLaiDaTra] >= 0))
GO
ALTER TABLE [dbo].[GiaoDichKH] CHECK CONSTRAINT [CK__GiaoDichK__SoTie__1FCDBCEB]
GO
/****** Object:  Check [CK__GiaoDichN__SoTie__531856C7]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__531856C7]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
ALTER TABLE [dbo].[GiaoDichNCC]  WITH CHECK ADD  CONSTRAINT [CK__GiaoDichN__SoTie__531856C7] CHECK  (([SoTienVay] >= 0))
GO
ALTER TABLE [dbo].[GiaoDichNCC] CHECK CONSTRAINT [CK__GiaoDichN__SoTie__531856C7]
GO
/****** Object:  Check [CK__GiaoDichN__SoTie__55009F39]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__55009F39]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
ALTER TABLE [dbo].[GiaoDichNCC]  WITH CHECK ADD  CONSTRAINT [CK__GiaoDichN__SoTie__55009F39] CHECK  (([SoTienConNo] >= 0))
GO
ALTER TABLE [dbo].[GiaoDichNCC] CHECK CONSTRAINT [CK__GiaoDichN__SoTie__55009F39]
GO
/****** Object:  Check [CK__GiaoDichN__SoTie__56E8E7AB]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__GiaoDichN__SoTie__56E8E7AB]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
ALTER TABLE [dbo].[GiaoDichNCC]  WITH CHECK ADD  CONSTRAINT [CK__GiaoDichN__SoTie__56E8E7AB] CHECK  (([SoTienLaiDaTra] >= 0))
GO
ALTER TABLE [dbo].[GiaoDichNCC] CHECK CONSTRAINT [CK__GiaoDichN__SoTie__56E8E7AB]
GO
/****** Object:  Check [CK__HanTraLai__KyHan__4E1E9780]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraLai__KyHan__4E1E9780]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]'))
ALTER TABLE [dbo].[HanTraLaiKH]  WITH CHECK ADD  CONSTRAINT [CK__HanTraLai__KyHan__4E1E9780] CHECK  (([KyHanLai] > 0))
GO
ALTER TABLE [dbo].[HanTraLaiKH] CHECK CONSTRAINT [CK__HanTraLai__KyHan__4E1E9780]
GO
/****** Object:  Check [CK__HanTraLai__KyHan__57A801BA]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraLai__KyHan__57A801BA]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]'))
ALTER TABLE [dbo].[HanTraLaiNCC]  WITH CHECK ADD  CONSTRAINT [CK__HanTraLai__KyHan__57A801BA] CHECK  (([KyHanLai] > 0))
GO
ALTER TABLE [dbo].[HanTraLaiNCC] CHECK CONSTRAINT [CK__HanTraLai__KyHan__57A801BA]
GO
/****** Object:  Check [CK__HanTraNoK__KyHan__52E34C9D]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraNoK__KyHan__52E34C9D]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]'))
ALTER TABLE [dbo].[HanTraNoKH]  WITH CHECK ADD  CONSTRAINT [CK__HanTraNoK__KyHan__52E34C9D] CHECK  (([KyHanNo] > 0))
GO
ALTER TABLE [dbo].[HanTraNoKH] CHECK CONSTRAINT [CK__HanTraNoK__KyHan__52E34C9D]
GO
/****** Object:  Check [CK__HanTraNoN__KyHan__5C6CB6D7]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__HanTraNoN__KyHan__5C6CB6D7]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]'))
ALTER TABLE [dbo].[HanTraNoNCC]  WITH CHECK ADD  CONSTRAINT [CK__HanTraNoN__KyHan__5C6CB6D7] CHECK  (([KyHanNo] > 0))
GO
ALTER TABLE [dbo].[HanTraNoNCC] CHECK CONSTRAINT [CK__HanTraNoN__KyHan__5C6CB6D7]
GO
/****** Object:  Check [CK__PhieuChi__SoTien__2180FB33]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuChi__SoTien__2180FB33]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [CK__PhieuChi__SoTien__2180FB33] CHECK  (([SoTienChi] > 0))
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [CK__PhieuChi__SoTien__2180FB33]
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__2DE6D218]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__2DE6D218]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__KyHan__2DE6D218] CHECK  (([KyHanNo] > 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoKH] CHECK CONSTRAINT [CK__PhieuNhan__KyHan__2DE6D218]
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__2FCF1A8A]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__2FCF1A8A]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__KyHan__2FCF1A8A] CHECK  (([KyHanLai] > 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoKH] CHECK CONSTRAINT [CK__PhieuNhan__KyHan__2FCF1A8A]
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__31B762FC]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__31B762FC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__KyHan__31B762FC] CHECK  (([KyHanThongBao] > 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoKH] CHECK CONSTRAINT [CK__PhieuNhan__KyHan__31B762FC]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__2739D489]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__2739D489]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__2739D489] CHECK  (([SoTienVay] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoKH] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__2739D489]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__29221CFB]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__29221CFB]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__29221CFB] CHECK  (([SoTienConNo] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoKH] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__29221CFB]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__2B0A656D]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__2B0A656D]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__2B0A656D] CHECK  (([SoTienLaiDaTra] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoKH] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__2B0A656D]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__3864608B]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__3864608B]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
ALTER TABLE [dbo].[PhieuNhanNoKHCT]  WITH CHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__3864608B] CHECK  (([SoTienVay] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoKHCT] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__3864608B]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__395884C4]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__395884C4]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
ALTER TABLE [dbo].[PhieuNhanNoKHCT]  WITH CHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__395884C4] CHECK  (([SoTienTra] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoKHCT] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__395884C4]
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__634EBE90]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__634EBE90]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__KyHan__634EBE90] CHECK  (([KyHanNo] > 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoNCC] CHECK CONSTRAINT [CK__PhieuNhan__KyHan__634EBE90]
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__65370702]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__65370702]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__KyHan__65370702] CHECK  (([KyHanLai] > 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoNCC] CHECK CONSTRAINT [CK__PhieuNhan__KyHan__65370702]
GO
/****** Object:  Check [CK__PhieuNhan__KyHan__671F4F74]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__KyHan__671F4F74]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__KyHan__671F4F74] CHECK  (([KyHanThongBao] > 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoNCC] CHECK CONSTRAINT [CK__PhieuNhan__KyHan__671F4F74]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__5CA1C101]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__5CA1C101]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__5CA1C101] CHECK  (([SoTienVay] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoNCC] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__5CA1C101]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__5E8A0973]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__5E8A0973]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__5E8A0973] CHECK  (([SoTienConNo] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoNCC] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__5E8A0973]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__607251E5]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__607251E5]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC]  WITH NOCHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__607251E5] CHECK  (([SoTienLaiDaTra] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoNCC] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__607251E5]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__6DCC4D03]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__6DCC4D03]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
ALTER TABLE [dbo].[PhieuNhanNoNCCCT]  WITH CHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__6DCC4D03] CHECK  (([SoTienVay] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoNCCCT] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__6DCC4D03]
GO
/****** Object:  Check [CK__PhieuNhan__SoTie__6EC0713C]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuNhan__SoTie__6EC0713C]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
ALTER TABLE [dbo].[PhieuNhanNoNCCCT]  WITH CHECK ADD  CONSTRAINT [CK__PhieuNhan__SoTie__6EC0713C] CHECK  (([SoTienTra] >= 0))
GO
ALTER TABLE [dbo].[PhieuNhanNoNCCCT] CHECK CONSTRAINT [CK__PhieuNhan__SoTie__6EC0713C]
GO
/****** Object:  Check [CK__PhieuThu__SoTien__1BC821DD]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK__PhieuThu__SoTien__1BC821DD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [CK__PhieuThu__SoTien__1BC821DD] CHECK  (([SoTienThu] > 0))
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [CK__PhieuThu__SoTien__1BC821DD]
GO
/****** Object:  ForeignKey [fk_GD_KH]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_GD_KH]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichKH]'))
ALTER TABLE [dbo].[GiaoDichKH]  WITH NOCHECK ADD  CONSTRAINT [fk_GD_KH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[GiaoDichKH] CHECK CONSTRAINT [fk_GD_KH]
GO
/****** Object:  ForeignKey [fk_GD_NCC]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_GD_NCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoDichNCC]'))
ALTER TABLE [dbo].[GiaoDichNCC]  WITH NOCHECK ADD  CONSTRAINT [fk_GD_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[GiaoDichNCC] CHECK CONSTRAINT [fk_GD_NCC]
GO
/****** Object:  ForeignKey [fk_PNNKH_HanTraLaiKH]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKH_HanTraLaiKH]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiKH]'))
ALTER TABLE [dbo].[HanTraLaiKH]  WITH CHECK ADD  CONSTRAINT [fk_PNNKH_HanTraLaiKH] FOREIGN KEY([SoPhieuNhanNo])
REFERENCES [dbo].[PhieuNhanNoKH] ([SoPhieuNhanNo])
GO
ALTER TABLE [dbo].[HanTraLaiKH] CHECK CONSTRAINT [fk_PNNKH_HanTraLaiKH]
GO
/****** Object:  ForeignKey [fk_PNNNCC_HanTraLaiNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCC_HanTraLaiNCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraLaiNCC]'))
ALTER TABLE [dbo].[HanTraLaiNCC]  WITH CHECK ADD  CONSTRAINT [fk_PNNNCC_HanTraLaiNCC] FOREIGN KEY([SoPhieuNhanNo])
REFERENCES [dbo].[PhieuNhanNoNCC] ([SoPhieuNhanNo])
GO
ALTER TABLE [dbo].[HanTraLaiNCC] CHECK CONSTRAINT [fk_PNNNCC_HanTraLaiNCC]
GO
/****** Object:  ForeignKey [fk_PNNKH_HanTraNoKH]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKH_HanTraNoKH]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoKH]'))
ALTER TABLE [dbo].[HanTraNoKH]  WITH CHECK ADD  CONSTRAINT [fk_PNNKH_HanTraNoKH] FOREIGN KEY([SoPhieuNhanNo])
REFERENCES [dbo].[PhieuNhanNoKH] ([SoPhieuNhanNo])
GO
ALTER TABLE [dbo].[HanTraNoKH] CHECK CONSTRAINT [fk_PNNKH_HanTraNoKH]
GO
/****** Object:  ForeignKey [fk_PNNNCC_HanTraNoNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCC_HanTraNoNCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[HanTraNoNCC]'))
ALTER TABLE [dbo].[HanTraNoNCC]  WITH CHECK ADD  CONSTRAINT [fk_PNNNCC_HanTraNoNCC] FOREIGN KEY([SoPhieuNhanNo])
REFERENCES [dbo].[PhieuNhanNoNCC] ([SoPhieuNhanNo])
GO
ALTER TABLE [dbo].[HanTraNoNCC] CHECK CONSTRAINT [fk_PNNNCC_HanTraNoNCC]
GO
/****** Object:  ForeignKey [fk_NguoiDung_LoaiNguoiDung]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_NguoiDung_LoaiNguoiDung]') AND parent_object_id = OBJECT_ID(N'[dbo].[NguoiDung]'))
ALTER TABLE [dbo].[NguoiDung]  WITH NOCHECK ADD  CONSTRAINT [fk_NguoiDung_LoaiNguoiDung] FOREIGN KEY([MaLoaiNguoiDung])
REFERENCES [dbo].[LoaiNguoiDung] ([MaLoaiNguoiDung])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [fk_NguoiDung_LoaiNguoiDung]
GO
/****** Object:  ForeignKey [fk_PC_KC]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PC_KC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [fk_PC_KC] FOREIGN KEY([MaKC])
REFERENCES [dbo].[KhoanChi] ([MaKC])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [fk_PC_KC]
GO
/****** Object:  ForeignKey [fk_PC_NV]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PC_NV]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuChi]'))
ALTER TABLE [dbo].[PhieuChi]  WITH NOCHECK ADD  CONSTRAINT [fk_PC_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [fk_PC_NV]
GO
/****** Object:  ForeignKey [fk_PNNKH_GD]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKH_GD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKH]'))
ALTER TABLE [dbo].[PhieuNhanNoKH]  WITH NOCHECK ADD  CONSTRAINT [fk_PNNKH_GD] FOREIGN KEY([MaGD])
REFERENCES [dbo].[GiaoDichKH] ([MaGD])
GO
ALTER TABLE [dbo].[PhieuNhanNoKH] CHECK CONSTRAINT [fk_PNNKH_GD]
GO
/****** Object:  ForeignKey [fk_PNNKHCT_LoaiPhieu]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKHCT_LoaiPhieu]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
ALTER TABLE [dbo].[PhieuNhanNoKHCT]  WITH CHECK ADD  CONSTRAINT [fk_PNNKHCT_LoaiPhieu] FOREIGN KEY([MaLoaiPhieu])
REFERENCES [dbo].[LoaiPhieu] ([MaLoaiPhieu])
GO
ALTER TABLE [dbo].[PhieuNhanNoKHCT] CHECK CONSTRAINT [fk_PNNKHCT_LoaiPhieu]
GO
/****** Object:  ForeignKey [fk_PNNKHCT_PNNKH]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNKHCT_PNNKH]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoKHCT]'))
ALTER TABLE [dbo].[PhieuNhanNoKHCT]  WITH NOCHECK ADD  CONSTRAINT [fk_PNNKHCT_PNNKH] FOREIGN KEY([SoPhieuNhanNo])
REFERENCES [dbo].[PhieuNhanNoKH] ([SoPhieuNhanNo])
GO
ALTER TABLE [dbo].[PhieuNhanNoKHCT] CHECK CONSTRAINT [fk_PNNKHCT_PNNKH]
GO
/****** Object:  ForeignKey [fk_PNNNCC_GD]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCC_GD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCC]'))
ALTER TABLE [dbo].[PhieuNhanNoNCC]  WITH NOCHECK ADD  CONSTRAINT [fk_PNNNCC_GD] FOREIGN KEY([MaGD])
REFERENCES [dbo].[GiaoDichNCC] ([MaGD])
GO
ALTER TABLE [dbo].[PhieuNhanNoNCC] CHECK CONSTRAINT [fk_PNNNCC_GD]
GO
/****** Object:  ForeignKey [fk_PNNNCCCT_LoaiPhieu]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCCCT_LoaiPhieu]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
ALTER TABLE [dbo].[PhieuNhanNoNCCCT]  WITH CHECK ADD  CONSTRAINT [fk_PNNNCCCT_LoaiPhieu] FOREIGN KEY([MaLoaiPhieu])
REFERENCES [dbo].[LoaiPhieu] ([MaLoaiPhieu])
GO
ALTER TABLE [dbo].[PhieuNhanNoNCCCT] CHECK CONSTRAINT [fk_PNNNCCCT_LoaiPhieu]
GO
/****** Object:  ForeignKey [fk_PNNNCCCT_PNNNCC]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PNNNCCCT_PNNNCC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuNhanNoNCCCT]'))
ALTER TABLE [dbo].[PhieuNhanNoNCCCT]  WITH NOCHECK ADD  CONSTRAINT [fk_PNNNCCCT_PNNNCC] FOREIGN KEY([SoPhieuNhanNo])
REFERENCES [dbo].[PhieuNhanNoNCC] ([SoPhieuNhanNo])
GO
ALTER TABLE [dbo].[PhieuNhanNoNCCCT] CHECK CONSTRAINT [fk_PNNNCCCT_PNNNCC]
GO
/****** Object:  ForeignKey [fk_PT_KH]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PT_KH]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
ALTER TABLE [dbo].[PhieuThu]  WITH NOCHECK ADD  CONSTRAINT [fk_PT_KH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [fk_PT_KH]
GO
/****** Object:  ForeignKey [fk_PT_KT]    Script Date: 04/10/2012 12:48:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_PT_KT]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhieuThu]'))
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [fk_PT_KT] FOREIGN KEY([MaKT])
REFERENCES [dbo].[KhoanThu] ([MaKT])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [fk_PT_KT]
GO
