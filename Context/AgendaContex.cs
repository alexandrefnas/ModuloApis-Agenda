using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
	public class AgendaContex : DbContext
	{
		public AgendaContex(DbContextOptions<AgendaContex> options) : base(options)
		{
			
		}
		
		public DbSet<Contato> Contatos{ get; set; }
		
		
	}
}