Public Class Todo
    Private tasks As Dictionary(Of Integer, String)
    Private lastTaskId As Integer

    Public Sub New()
        tasks = New Dictionary(Of Integer, String)()
        lastTaskId = 0
    End Sub

    Public Function AddTask(taskName As String) As Integer
       lastTaskId += 1
       tasks.Add(lastTaskId, taskName)
       Return lastTaskId
    End Function

    Public Sub RemoveTask(taskId As Integer)
        If tasks.ContainsKey(taskId) Then
            tasks.Remove(taskId)
        End If
    End Sub

    Public Sub UpdateTask(taskId As Integer, updatedTaskName As String)
       If tasks.ContainsKey(taskId) Then
            tasks(taskId) = updatedTaskName
       End If
    End Sub

    Public Function GetTask(taskId As Integer) As String
        Dim taskName As String = Nothing
        If tasks.TryGetValue(taskId, taskName) Then
            Return taskName
        Else
            Return Nothing
        End If
    End Function

    Public Function GetAllTasks() As Dictionary(Of Integer, String)
        Return New Dictionary(Of Integer, String)(tasks)
    End Function
    
    Public Shared Sub Main()
        Dim todoApp As New Todo()
        Dim taskId As Integer = todoApp.AddTask("Complete VB.NET homework")
        Console.WriteLine("Added task with ID: " & taskId.ToString())

        Console.WriteLine("Current Tasks:")
        For Each kvp As KeyValuePair(Of Integer, String) In todoApp.GetAllTasks()
            Console.WriteLine("ID: " & kvp.Key.ToString() & " - Task: " & kvp.Value)
        Next

        todoApp.UpdateTask(taskId, "Complete VB.NET project")
        Console.WriteLine("Updated task: " & todoApp.GetTask(taskId))

        todoApp.RemoveTask(taskId)
        Console.WriteLine("Tasks after removal:")
        For Each kvp As KeyValuePair(Of Integer, String) In todoApp.GetAllTasks()
            Console.WriteLine("ID: " & kvp.Key.ToString() & " - Task: " & kvp.Value)
        Next

        Console.ReadLine()
    End Sub
End Class
