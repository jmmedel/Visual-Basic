'These are all Integers
<Flags()>
Public Enum Sports
    Biking      '0
    Climbing    '1
    Swimming    '2
    Running     '3
    Skiing      '4
End Enum

Public Enum LongSports As Long
    Biking
    Climbing
    'and so on...
End Enum

<Flags()> Public Enum ClsCompliantEnum As Byte
    FirstValue = 0
    SecondValue = 1
    ThirdValue = 2
End Enum