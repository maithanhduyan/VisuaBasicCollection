Module Module1
    Public Enum Temperature
        Low
        Medium
        High
    End Enum
    Sub Main()
        Dim value As Temperature = Temperature.Medium
        Select Case value
            Case Temperature.Low
                Console.WriteLine("Low Temperature")
                Exit Select
            Case Temperature.Medium
                Console.WriteLine("Mediuam Temperature")
                Exit Select
            Case Temperature.High
                Console.WriteLine("High Temperature")
                Exit Select
        End Select
        Console.ReadLine()
    End Sub

End Module
