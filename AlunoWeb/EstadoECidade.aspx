<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoECidade.aspx.cs" Inherits="AlunoWeb.EstadoECidade" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />
    <h1>Estado e Cidade</h1>

    Estado:
    <asp:DropDownList runat="server" ID="drpEstado" 
        OnSelectedIndexChanged="drpEstado_SelectedIndexChanged" AutoPostBack="true">
    </asp:DropDownList>

    <br /><br />

    <asp:Label Text="Cidade:" ID="lblCidade" runat="server" Visible="false" />
    <asp:DropDownList runat="server" ID="drpCidade" Visible="false">
    </asp:DropDownList>

</asp:Content>
