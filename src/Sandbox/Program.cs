using bottlenoselabs.SDL;

var app = new SandboxApp();
app.Run();

class SandboxApp : Application
{
    private Window _window = null!;

    protected override void OnStart()
    {
        _window = CreateWindow(new WindowOptions
        {
            Title = "Sandbox",
            Width = 1280,
            Height = 720
        });
    }

    protected override void OnKeyDown(in KeyboardEvent e)
    {
        if (e.Key == KeyboardKey.Escape)
            Exit();
    }
}