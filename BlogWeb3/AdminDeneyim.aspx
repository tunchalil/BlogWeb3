<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyim.aspx.cs" Inherits="BlogWeb3.AdminDeneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">

        <asp:TextBox ID="SearchBox" runat="server" CssClass="form-control" placeholder="Id Gir" ></asp:TextBox>
        <button type="button" runat="server" class="btn btn-primary btn-danger btn-large" onserverclick="btnClk">Ara</button>
        </br>
        </br>

        <table class="table table-bordered">


        <tr>

            <th>ID</th>
            <th>BAŞLIK</th>
            <th>ALT BAŞLIK</th>
            <th>AÇIKLAMA</th>
            <th>TARİH</th>

        </tr>

        <tbody>

            <asp:Repeater ID="Repeater1" runat="server">

                <ItemTemplate>

                    <tr>

                        <td><%#Eval("Id") %></td>
                        <td><%#Eval("Baslik") %></td>
                        <td><%#Eval("AltBaslik") %></td>
                        <td><%#Eval("Aciklama") %></td>
                        <td><%#Eval("Tarih") %></td>

                        <td> <asp:HyperLink NavigateUrl='<%# "AdminDeneyimSil.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink> 
                        <td> <asp:HyperLink NavigateUrl='<%# "AdminDeneyimGuncelle.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink> 
                        </td>


                    </tr>

                </ItemTemplate>


            </asp:Repeater>


        </tbody>
           


    </table>
        <asp:HyperLink NavigateUrl="~/AdminDeneyimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Deneyim Ekle</asp:HyperLink>
        
    </form>

    

    


</asp:Content>
