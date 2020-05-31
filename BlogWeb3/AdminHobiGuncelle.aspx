<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiGuncelle.aspx.cs" Inherits="BlogWeb3.AdminHobiGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

      <form id="Form1" runat="server">

            <div class="form-group">

                <div>
                    <asp:Label ID="Label1" runat="server" Text="HOBI"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
               

                 <asp:Button ID="Button2" runat="server" Text="Hobiyi Güncelle" CssClass="btn btn-danger" OnClick="Button2_Click" />



            <//div>

        </form>



</asp:Content>
