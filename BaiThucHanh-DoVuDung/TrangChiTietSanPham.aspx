<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="TrangChiTietSanPham.aspx.cs" Inherits="BaiThucHanh_DoVuDung.TrangSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 100px;  width:100%; display:block; align-items:center; margin-left: 160px;">
         <p style="color:#000000;font-family: 'Dancing Script', cursive;font-weight:bold; text-align:center; padding-bottom: 8px;font-size:32px;">
           <asp:Literal ID="ltTenSanPham" runat="server"></asp:Literal>

            </p>
    </div>
   
    <div style=" display:flex;">

        <div style="margin-left:160px;">
            
            <p>
                <asp:Image ID="imgHinhAnhSanPham" runat="server" />
            </p>
            <p style=" text-align:center; font-family: 'Roboto', sans-serif; font-weight:bold; font-size: 16px;">
                <b> $</b> <asp:Literal ID="ltGiaSanPham" runat="server"></asp:Literal>.00
            </p>
        </div>
        
        <div style="text-align:justify;font-family: 'Dancing Script', cursive;display:flex; justify-content:center; align-items:center; width:100%; font-size: 28px;">
             <p >
               <asp:Literal ID="ltMieuTaSanPham" runat="server"></asp:Literal>
            </p>
        </div>
       
        </div>
    
</asp:Content>
