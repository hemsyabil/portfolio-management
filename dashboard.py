import dash
import dash_bootstrap_components as dbc
import dash_html_components as html

app = dash.Dash(__name__, external_stylesheets=[dbc.themes.BOOTSTRAP])

app.layout = dbc.Container(
    [
        dbc.Row(
            dbc.Col(html.H1("Bootstrap Layout Example", className="text-center mb-4"), width=12)
        ),
        dbc.Row(
            [
                dbc.Col(html.Div("Content Column 1"), width=4),
                dbc.Col(html.Div("Content Column 2"), width=4),
                dbc.Col(html.Div("Content Column 3"), width=4),
            ]
        ),
        dbc.Row(
            dbc.Col(html.Div("Footer"), width=12, className="text-center mt-4")
        ),
    ],
    fluid=True,
)

if __name__ == "__main__":
    app.run_server(debug=True)
