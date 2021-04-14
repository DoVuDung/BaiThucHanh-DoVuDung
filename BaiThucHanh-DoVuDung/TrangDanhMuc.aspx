<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="TrangDanhMuc.aspx.cs" Inherits="BaiThucHanh_DoVuDung.TrangDanhMuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div  style=" margin-left: 240px; display: flex; justify-content:space-between; flex-wrap:wrap; height: 100% ">
         <asp:Repeater ID="rptDanhSachSanPham" runat="server">
             <ItemTemplate>
                  <!-- Sản phẩm 1 -->
                    <div style="width: 25% ; ">
                        <p>
                            <img src="HinhAnh/<%# Eval("HINHANH") %>" style="width: 200px; height:200px"/>
                        </p>
                        <p style=" font-family: 'Roboto', sans-serif; text-align:center;"><a style=" color:black" href="TrangChiTietSanPham.aspx?idSanPham=<%# Eval("IDSANPHAM")%>">
                            <%# Eval("TENSANPHAM") %>
                           </a>
                        </p>
                        <p style=" font-family: 'Roboto', sans-serif; font-weight:bold ;text-align:center; margin-top: 8px;"> $ <%# Eval("DONGIA")%>.00</p>        
                   </div>
              </ItemTemplate>
          </asp:Repeater>
    </div>
</asp:Content>
