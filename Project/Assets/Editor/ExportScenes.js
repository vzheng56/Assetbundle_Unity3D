import UnityEditor;
@MenuItem("MyTools/Build Streamed Asset Bundle")
static function ExportResource () {
	var path = EditorUtility.SaveFilePanel ("Build Bundle", "", "*", "unity3d");
	if (path.Length != 0)
	{
		var levels : String[] = [EditorApplication.currentScene];
		BuildPipeline.BuildStreamedSceneAssetBundle (levels, path, BuildTarget.WebPlayer);
	}
}