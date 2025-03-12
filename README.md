# immerza-sdk-package

## Setup
* Add a GameObject with a ImmerzaLuaManager component into your scene
* After that you can add a LuaComponent to any GameObject you like and reference your Lua script, the fields you want to reference from within the scene and/or any assets you want to have available in your Lua script

## MonoBehaviour methods
### Most MonoBehaviour methods are supported (C# -> Lua):
* Awake -> awake
* Start -> start
* OnEnable -> on_enable
* OnDisable -> on_disable
* Update -> update
* OnDestroy -> on_destroy
#### Collision
* OnCollisionEnter -> on_collision_enter
* OnCollisionStay -> on_collision_stay
* OnCollisionExit -> on_collision_exit
* OnTriggerEnter -> on_trigger_enter
* OnTriggerStay -> on_trigger_stay
* OnTriggerExit -> on_trigger_exit
#### Example
```lua
function start()
	CS.UnityEngine.Debug.Log("Hello")
end

function update()
	CS.UnityEngine.Debug.Log("This message is coming from void Update().")
end
```
## C# and Unity Classes and Methods
* You can access them via 'CS' and then the namespace + class and then your desired Method.
* Objects that are instances of them can also be used, but some are restricted due to security reasons (namely UnityWebRequests, System.IO, etc...).
#### Example
```lua
function start()
	CS.UnityEngine.Debug.LogWarning("This is a warning.")
    self:GetComponent("MeshRenderer").enabled = false
end

local unity = CS.UnityEngine

function update()
	local x = unity.Mathf.Cos(unity.Time.time)
	local y = unity.Mathf.Sin(unity.Time.time)

	local new_pos = unity.Vector3(cube_location.transform.position.x, cube_location.transform.position.y, cube_location.transform.position.z)

    local new_rot = unity.Quaternion.Euler(x * 360.0, 0.0, y * 360.0)

    cube_to_spin.transform:SetPositionAndRotation(new_pos, new_rot)
end
```
## Communication between scripts
* You can use the Lua global environment to message between scripts
#### -- Custom Lua events and GetLuaComponent for 1-1 and n-1 communication will be available in SDK Version 0.5.2 (very soon) --