<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InserirDisciplinas.aspx.cs" Inherits="AlunoWeb.InserirDisciplinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Inserir Disciplinas</h1>

    <asp:TextBox runat="server" ID="txtNomeDisciplina" CssClass="btn-default" placeholder="Nome da disciplina" />
    <asp:Button Text="Inserir" CssClass="btn-control" ID="cmdInserir" runat="server" OnClick="cmdInserir_Click" />
    <asp:Label Text="" ID="lblResultado" ForeColor="Red" runat="server" />

    <br /><br />

    <h2>Lista Disciplinas</h2>
    <asp:GridView runat="server" ID="grdDisciplinas" CellPadding="10" CellSpacing="10" 
        AutoGenerateColumns="false" AllowPaging="true" PageSize="2" OnPageIndexChanging="grdDisciplinas_PageIndexChanging">

        <AlternatingRowStyle BackColor="#f1f1f1" />
        <HeaderStyle BackColor="#dedede" />

        <Columns>
            <asp:BoundField DataField="IdDisc" HeaderText="Id" />
            <asp:BoundField DataField="DescricaoDisc" HeaderText="Nome da Disciplina" />
        </Columns>
    </asp:GridView>

</asp:Content>
