<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApplication1.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
            Course Name:
                        </td>
                    <td>
            <asp:TextBox ID="Textname" runat="server"></asp:TextBox>
            </td>
                    </tr>
                <tr>
                    <td>
              Credit:
                        </td>
            <td>
                    <asp:TextBox ID="Textcredit" runat="server"></asp:TextBox>
            </td>
                    </tr>
                <tr>
                    <td>
            Semester:
                        </td>
                    <td>
            <asp:TextBox ID="Textsemester" runat="server"></asp:TextBox>
            </td>
                    </tr>
                <tr>
                    <td>
            Id:
                        </td>
                    <td>
            <asp:TextBox ID="Textid" runat="server"></asp:TextBox>
            </td>
                    </tr>
                <tr>
                    <td>
            <asp:Button ID="insert" runat="server" Text="Insert" OnClick="insert_Click" />
            </td>
                    <td>
            <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />
            <asp:Button ID="state_cookie" runat="server" Text="CookieState" OnClick="cookie_Click" />
            <asp:Button ID="state_session" runat="server" Text="SessionState" OnClick="session_Click" />
            </td><td>
                        <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
            </td><td>
                <asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" />
        </td>
             </tr>   </table>
                </div>
    </form>
</body>
</html>
