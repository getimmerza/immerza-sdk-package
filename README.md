# immerza-sdk-package

## Setup
* Add a GameObject with an ImmerzaLuaManager component into your scene
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
* You can access them via 'CS' and then the namespace + class and then your desired Method
* Objects that are instances of them can also be used, but some are restricted due to security reasons (namely UnityWebRequests, System.IO, etc...)
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
* It is also to just directly get the LuaComponent and its scriptEnv to execute functions or access variables on the object
#### Example:
```Lua
obj:GetComponent("LuaComponent").scriptEnv.do_something()
obj:GetComponent("LuaComponent").scriptEnv.some_variable
```

* The SDK has an event system where you can register and trigger events from any script and provide a custom payload
#### Example:
**OneLuaScript.lua:**
```Lua
local lua_util = CS.ImmerzaSDK.Lua.LuaComponent

function awake()
	lua_util.RegisterEvent("CubeNotify", function (event_data)
			unity.Debug.Log(event_data.message)
		end
	)
end
```

**AnotherLuaScript.lua:**
```Lua
local lua_util = CS.ImmerzaSDK.Lua.LuaComponent

function start()
    lua_util.TriggerEvent("CubeNotify", { message = "Hello from GetLuaComponentReference!" })
end

-- Result: OneLuaScript instance prints "Hello from GetLuaComponentReference!"
```

## UI
* The SDK has default Unity UI support
#### Example
```lua
local unity = CS.UnityEngine
local crt_num = 0

function start()
	local num_comp = num_field:GetComponent("TMP_Text")
	num_comp.text = crt_num
	increment_button:GetComponent("Button").onClick:AddListener(function()
		crt_num = crt_num + 1
		num_comp.text = crt_num
	end)
end
```
## Things to check when exporting the scene:
* Check that only one LuaManager instance is present in the scene
* Subscribe to the OnPauseRequested event in the class ImmerzaEvents and provide a pause implementation
#### Example:
```Lua
function awake()
	CS.ImmerzaSDK.ImmerzaEvents.OnPauseRequested('+', on_pause_requested)
end

function on_pause_requested(shouldPause)
	if shouldPause then
		-- implement pause
	else 
		-- implement unpause
	end
end
```
<br>

* If you want to end the scene, you can call EndScene()
#### Example:
```Lua
function start()
	CS.ImmerzaSDK.ImmerzaEvents.EndScene()
end
```
