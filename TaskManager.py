class TaskDevice:
    def execute(self):
        pass


class Printer(TaskDevice):
    def execute(self):
        print("Printing document...")


class Scanner(TaskDevice):
    def execute(self):
        print("Scanning document...")


class TaskManager:
    def execute_task(self, task_id, device: TaskDevice):
        print(f"Executing Task: {task_id}")
        device.execute()


# Usage
printer = Printer()
scanner = Scanner()

scheduler = TaskManager()

scheduler.execute_task(101, printer)
scheduler.execute_task(102, scanner)
