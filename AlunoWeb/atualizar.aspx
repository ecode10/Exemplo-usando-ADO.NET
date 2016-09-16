<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="atualizar.aspx.cs" Inherits="AlunoWeb.atualizar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br />
    <asp:HiddenField ID="hfIdAluno" runat="server" />

    <asp:TextBox runat="server" ID="txtNome" /><br />
    <asp:TextBox runat="server" id="txtEmail" /><br /><br />
    
    <asp:Button Text="Atualizar" ID="cmdAtualizar" OnClick="cmdAtualizar_Click" runat="server" />


</asp:Content>
