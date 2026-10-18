<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LibraryManagement.aspx.cs" Inherits="LibraryManagement.LibraryManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Library Management</title>
    <style type="text/css">
        .auto-style1 {
            width: 1048px;
            border-collapse: collapse;
            height: 322px;
            border: 1px solid #000000;
        }
        .auto-style2 {
            width: 97px;
        }
        .auto-style3 {
            width: 135px;
        }
        .auto-style4 {
            width: 81px;
        }
        .auto-style5 {
            width: 90px;
        }
        .auto-style6 {
            width: 129px;
        }
        .auto-style7 {
            width: 122px;
        }
        .auto-style8 {
            width: 97px;
            height: 34px;
        }
        .auto-style9 {
            width: 135px;
            height: 34px;
        }
        .auto-style10 {
            height: 34px;
        }
        .auto-style11 {
            width: 43px;
        }
        .auto-style12 {
            height: 34px;
            width: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
            <asp:Label ID="lblBook" runat="server" Text="Book:"></asp:Label>
                    </td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtBook" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">
            <asp:Label ID="lblAuthor" runat="server" Text="Author:"></asp:Label>
                    </td>
                    <td class="auto-style9">
            <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10" colspan="4">&nbsp;<asp:CheckBox ID="chkBook" runat="server" Text="Book" />
            &nbsp;<asp:CheckBox ID="chkEbook" runat="server" Text="Ebook" />
            &nbsp;<asp:CheckBox ID="chkAudiobook" runat="server" Text="Audiobook" />
                    </td>
                    <td class="auto-style10"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:Label ID="lblISBN" runat="server" Text="ISBN:"></asp:Label>
                    </td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtISBN" runat="server"></asp:TextBox>
                    </td>
                    <td colspan="6" rowspan="5">
            <asp:ListBox ID="lstLibrary" runat="server" Height="138px" Width="791px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:Label ID="lblTotalPages" runat="server" Text="Total Pages:"></asp:Label>
                    </td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtTotalPages" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
            <asp:Label ID="lblCurrentPage" runat="server" Text="Current Page:"></asp:Label>
                    </td>
                    <td class="auto-style3">
            <asp:TextBox ID="txtCurrentPage" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">&nbsp;<asp:Button ID="btnAddBook" runat="server" Text="Add Book" OnClick="btnAddBook_Click" Width="92px" />
            &nbsp;<asp:Button ID="btnRemoveBook" runat="server" Text="Remove Book" OnClick="btnRemoveBook_Click" Width="122px" />
            &nbsp;<asp:Button ID="btnShowLibrary" runat="server" Text="Show Library" OnClick="btnShowLibrary_Click" />
            &nbsp;<asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" Width="81px" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
