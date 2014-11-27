#pragma strict

function Start () {

}

function Update () {

}
// Build a folder containing unity3d file and html file
	@MenuItem ("Build/BuildWebplayer")
static function MyBuild(){
    var levels : String[] = ["Assets/Scene1.unity", "Assets/Scene2.unity"];
    BuildPipeline.BuildPlayer( levels, "WebPlayerBuild", 
                   BuildTarget.WebPlayer, BuildOptions.None); 
}