# ModbusAddressScanner
🙏 大部分布局及逻辑代码由豆包（https://www.doubao.com/）生成，其中使用了NModules Nuget包。

ModbusAddressScanner 是一个用于扫描和识别 Modbus 设备地址的工具。支持 Modbus RTU ，可自行扩展Modbus TCP。
## 功能特点
- 自动扫描 Modbus 设备地址范围0-254，使用读取保持寄存器功能码（0x03），若该地址对指令有响应即认为找到了从机地址。
- 支持自定义波特率、数据位、停止位和校验方式。
- 扫描结果以列表形式展示，包含从机地址和响应时间。
- 用户界面简洁易用，适合快速定位 Modbus 设备。
