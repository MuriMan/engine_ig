using Raylib_cs;
using static Raylib_cs.Raylib;

Dictionary<string, Scene> Scenes = new Dictionary<string, Scene>();

InitWindow(Globals.WINDOW_WIDTH, Globals.WINDOW_HEIGHT, "BLADE OF MIQUELLA");
SetTargetFPS(60);

foreach (KeyValuePair<string, Scene> i in Scenes)
	i.Value.Start();

while (!WindowShouldClose())
{
	foreach (KeyValuePair<string, Scene> i in Scenes)
		i.Value.Update(GetFrameTime());

	float dt = GetFrameTime();
	while (dt >= Globals.FIXED_DT)
	{
		foreach(KeyValuePair<string, Scene> i in Scenes)
		{
			i.Value.Tick();
		}

		dt -= Globals.FIXED_DT;
	}

	BeginDrawing();
		foreach (KeyValuePair<string, Scene> i in Scenes)
			i.Value.Draw();
	EndDrawing();
}

CloseWindow();
