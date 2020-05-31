<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimEkle.aspx.cs" Inherits="BlogWeb3.AdminEgitimEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="Form1" runat="server">

            <div class="form-group">

                <div>
                    <asp:Label ID="Label1" runat="server" Text="OKUL"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                
                </br>

                <div>
                    <asp:Label ID="Label2" runat="server" Text="BÖLÜM"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                
                </br>

                                <div>
                    <asp:Label ID="Label3" runat="server" Text="BAŞLIK"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                
                </br>

                                <div>
                    <asp:Label ID="Label4" runat="server" Text="NOT ORTALAMASI"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                
                </br>
                                <div>
                    <asp:Label ID="Label5" runat="server" Text="TARİH"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                
                </br>

                 <asp:Button ID="Button2" runat="server" Text="Eğitim Ekle" CssClass="btn btn-danger" OnClick="Button2_Click" />



            <//div>

        </form>


</asp:Content>
