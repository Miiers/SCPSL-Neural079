# SCPSL-Neural079 [中文名:中立079]
This plugin will make SCP079 in NeuralMode,generator will can't be open.So it mean he can't die.... But Alpha still can kill him.
SCP079 Will not affect The RoundENd,because he's Neural

翻译:
这个插件会使得SC079进入中立模式，发电机将无法被打开[无论你是什么卡]，这也意味着079变为无敌，但核弹依然能炸死他，
SCP079不会影响游戏进程结束，因为他是中立的


# How to use [如何使用]
Put the plugin in sm_plugins and start the server.

翻译:
将插件丢进sm_plugins文件夹下然后启动
# SCP079
When SCP079 Turn off the light will 3 times,then he next time turn off the light maybe will dead(Default:50%)
This probability can be modified in config_gameplay.

翻译:
当SCP079关灯超过3次后，下一次关灯可能会死亡（默认值:50%概率），这些参数可以在config_gameplay里修改


# Why do I want SCP079 to be neutral(为什么我要079中立)


- Help to kill SCP （+60XP）

- Some players won't turn off the generator

- There is only one road on the map, but there is a Tesla, 079 can control Tesla, so that players can not get in the site.


- 协助击杀SCP（+60经验）

- 一些玩家不会关发电机

- 当地图必经之路上有电网，079可以利用这个无限电击使得玩家无法通过电网进入设施，拖延时间



</tbody>
</table>
<h1><a id="user-content-参数设置-中文" class="anchor" aria-hidden="true" href="#参数设置-中文"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>参数设置 （中文）</h1>
<table>
<thead>
<tr>
<th>参数名</th>
<th align="center">参数类型</th>
<th align="center">默认值</th>
<th>注释</th>
</tr>
</thead>
<tbody>
<tr>
<td>Neutral_Enable</td>
<td align="center">布尔值</td>
<td align="center">True</td>
<td>开启/关闭插件</td>
</tr>
<tr>
<td>Neutral079MaxAP</td>
<td align="center">整数</td>
<td align="center">110</td>
<td>SCP079最大电力</td>
</tr>
<tr>
<td>Neutral079APPer</td>
<td align="center">整数</td>
<td align="center">2</td>
<td>SCP079最大电力每秒恢复速度</td>
</tr>
<tr>
<td>Neutral079LockdownCount</td>
<td align="center">整数</td>
<td align="center">3</td>
<td>SCP079关灯的安全阈值</td>
</tr>
<tr>
<td>Neutral079LockdownDead</td>
<td align="center">整数</td>
<td align="center">50</td>
<td>SCP079关灯的超过安全阈值后多少概率(%)会死亡</td>
</tr>
</tbody>
</tbody>
</table>


<h1><a id="user-content-Config" class="anchor" aria-hidden="true" href="#Config Options"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Config (Engilsh)</h1>
<table>
<thead>
<tr>
<th>Config Option</th>
<th align="center">Value Type</th>
<th align="center">Default Value</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr>
<td>Neutral_Enable</td>
<td align="center">Boolean</td>
<td align="center">True</td>
<td>Enable/Disable the Plugin</td>
</tr>
<tr>
<td>Neutral079MaxAP</td>
<td align="center">Integer</td>
<td align="center">110</td>
<td>SCP079MaxPower</td>
</tr>
<tr>
<td>Neutral079APPer</td>
<td align="center">Integer</td>
<td align="center">2</td>
<td>SCP079 Power recovery speed</td>
</tr>
<tr>
<td>Neutral079LockdownCount</td>
<td align="center">Integer</td>
<td align="center">3</td>
<td>SCP079 can safe to lockdown count</td>
</tr>
<tr>
<td>Neutral079LockdownDead</td>
<td align="center">Integer</td>
<td align="center">50</td>
<td>When SCP079 exceeds the safe lockdown,lockdown die probability</td>
</tr>
</tbody>
