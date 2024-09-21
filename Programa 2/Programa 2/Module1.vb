Module Module1

    Sub Main()
        Dim numeroIngresado As Double


        Console.Write("Ingrese un número: ")
        Dim input As String = Console.ReadLine()


        If Double.TryParse(input, numeroIngresado) Then
            If numeroIngresado > 0 Then
                Console.WriteLine("Tu numero es positivo.")

            ElseIf numeroIngresado < 0 Then
                Console.WriteLine("Tu numero es negativo.")

            Else
                Console.WriteLine("Tu numero es cero")

            End If

        End If





            Console.ReadKey()

    End Sub

End Module
