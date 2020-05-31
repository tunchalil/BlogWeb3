<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminOduller.aspx.cs" Inherits="BlogWeb3.AdminOduller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
        <table class="table table-bordered">


        <tr>

            <th>ID</th>
            <th>ODUL</th>

        </tr>

        <tbody>

            <asp:Repeater ID="Repeater1" runat="server">

                <ItemTemplate>

                    <tr>

                        <td><%#Eval("ID") %></td>
                        <td><%#Eval("Odullerim") %></td>
     

                        <td> <asp:HyperLink NavigateUrl='<%# "AdminOdullerSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink> 
                        <td> <asp:HyperLink NavigateUrl='<%# "AdminOdullerGuncelle.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink> 
                        </td>


                    </tr>

                </ItemTemplate>


            </asp:Repeater>


        </tbody>
           


    </table>
        <asp:HyperLink NavigateUrl="~/AdminOdullerEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Ödül Ekle</asp:HyperLink>

    </form>


</asp:Content>
