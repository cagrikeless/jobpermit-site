<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data.aspx.cs" Inherits="jobpermit_site.data" %>

<!DOCTYPE html>
<html>
<head>
    <title>Admin Panel</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <style>
        ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            overflow: hidden;
            background-color: #808080;
        }

        li {
            float: left;
        }

            li a {
                display: block;
                color: white;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
            }

                li a:hover:not(.active) {
                    background-color: #00ff21;
                }

        .active {
            background-color: #4CAF50;
        }
    </style>
</head>
<body>

    <ul>
        <li><a href="#home">Home</a></li>
        <li><a href="#news">Persons</a></li>
        <li><a href="#passwords">Passwords</a></li>
        <li><a href="#contact">Yeni Kullanıcı</a></li>
    </ul>
    <form runat="server">
        <div style="margin-top: 15px">
            <table class="table table-bordered">
                <tr>
                    <th>ID</th>
                    <th>Mails</th>
                    <th>Passwords</th>
                    <th>Delete</th>
                    <th>Update</th>
                </tr>
                <asp:Repeater ID="usersRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ID")%></td>
                            <td><%# Eval("USERNAME")%></td>
                            <td><%# Eval("PASSWORD")%></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "DeletePage.aspx?ID="+Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "UpdatePage.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Update</asp:HyperLink></td>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>

</body>
</html>
