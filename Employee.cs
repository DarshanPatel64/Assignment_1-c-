using System;
namespace demos
{
    public class Employee{
        private int _id;
        private string _name;
        private string _department;
        public event EventHandler<string> getDetailsCalled ;
        public Employee(int id, string name, string department){
            this._id = id;
            this._name = name;
            this._department = department;
        }

        public string getName(){
            onDetailsCalled("getName()");
            return this._name;
        }
        public string getDepartmentName(){
            onDetailsCalled("getDepartmentName()");
            return this._department;
        }
        public int getId(){
            onDetailsCalled("getId()"); 
            return this._id;
        }
        public virtual void onDetailsCalled(string functionName){
            getDetailsCalled?.Invoke(this, functionName);
        }
        public void update(int id){
            this._id = id;
        }
        public void update(int id, string name){
            this._id = id;
            this._name = name;
        }
        public void update(int id, string name , string department){
            this._id = id;
            this._name = name;
            this._department = department;
        }
    }
}