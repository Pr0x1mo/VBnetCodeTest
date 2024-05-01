Public Class Counter
    Private count As Integer
    Private Const lowerLimit As Integer = -10
    Private Const upperLimit As Integer = 10

    Public Sub New()
        count = 0
    End Sub

    Public Sub IncrementBy1()
       if count < upperLimit Then
            
            count+=1
            
        End if
    End Sub

    Public Sub IncrementBy2()
    if count + 2 <= upperLimit Then
    count +=2
    ElseIf count < upperLimit Then
    count+=1
    End if


    End Sub

  
    Public Sub DecrementBy1()

        if count > lowerLimit Then
            count -= 1
        End if
    End Sub

    Public Sub DecrementBy2()
        if count - 2 >= lowerLimit Then
            count -=2
        ElseIf count > lowerLimit Then
            count -=1
        End if
       
    End Sub

    Public Sub Reset()
        count = 0
    End Sub

    Public Function GetCount() As Integer
        Return count
    End Function

    Public Shared Sub Main()
    Dim myCounter as New Counter()

    Console.WriteLine("Initial Count: " & myCounter.GetCount())

    myCounter.IncrementBy1()
    Console.WriteLine("After Incrementing by 1: " & myCounter.GetCount())
    myCounter.IncrementBy2()
    Console.WriteLine("After Incrementing by 2: " & myCounter.GetCount())

    myCounter.DecrementBy1()
    Console.Writeline("After Decrementing by 1: " &  myCounter.GetCount())
    myCounter.DecrementBy2()
    Console.WriteLine("After Decrementing by 2: " & myCounter.GetCount())

    myCounter.Reset()
    Console.WriteLine("After Reset: " & myCounter.GetCount())

    Console.ReadLine()
        ' Your console application logic goes here
    End Sub
End Class