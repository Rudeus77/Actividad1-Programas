Module Module1

    Sub Main()
        Dim edadIngresada As Integer = 0
        Dim mayorEdad As Integer = 18

        Console.Write("Ingrese su edad por favor: ")
        edadIngresada = Console.ReadLine()

        If edadIngresada >= mayorEdad Then
            Console.WriteLine("Eres mayor de edad.")

        Else
            Console.WriteLine("Eres menor de edad.")

        End If




        Console.ReadKey()


    End Sub

End Module
