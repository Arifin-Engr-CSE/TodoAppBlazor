using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppBlazor.Data
{
    public class TodoService
    {
        private readonly AppDbContext _appDbContext;
        public TodoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public async Task<List<Todo>> GetAllTodosAsync()
        {
            return await _appDbContext.Todos.ToListAsync();
        }
        

        public async Task<bool> InsertTodoAsync(Todo todo)
        {
            await _appDbContext.Todos.AddAsync(todo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        

       
        public async Task<Todo> GetTodoAsync(int Id)
        {
            Todo todo = await _appDbContext.Todos.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return todo;
        }
        

        
        public async Task<bool> UpdateTodoAsync(Todo todo)
        {
            _appDbContext.Todos.Update(todo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<bool> DeleteTodoAsync(Todo todo)
        {
            _appDbContext.Remove(todo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        

    }
}
