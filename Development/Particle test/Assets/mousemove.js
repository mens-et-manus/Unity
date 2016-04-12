#pragma strict

function Start () {

}

function Update () {
  var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
  // 10 meters in front of the camera:
  transform.position = ray.GetPoint(10) ;
}