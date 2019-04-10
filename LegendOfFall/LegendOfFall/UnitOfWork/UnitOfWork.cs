using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LegendOfFall.Repositories;
using LegendOfFall.Models;

namespace LegendOfFall.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        LOFEntities1 _context;

        public AboutRepository AboutRepository { get; set; }
        public AdminRepository AdminRepository { get; set; }
        public ApplicantRepository ApplicantRepository { get; set; }
        public BlogRepository BlogRepository { get; set; }
        public ContactRepository ContactRepository { get; set; }
        public JudgeRepository JudgeRepository { get; set; }
        public SeasonRepository SeasonRepository { get; set; }

        public UnitOfWork()
        {
            _context = new LOFEntities1();
            AboutRepository = new AboutRepository(_context);
            AdminRepository = new AdminRepository(_context);
            ApplicantRepository = new ApplicantRepository(_context);
            BlogRepository = new BlogRepository(_context);
            ContactRepository = new ContactRepository(_context);
            JudgeRepository = new JudgeRepository(_context);
            SeasonRepository = new SeasonRepository(_context);
        }
    }

    public interface IUnitOfWork
    {
        AboutRepository AboutRepository { get; set; }
        AdminRepository AdminRepository { get; set; }
        ApplicantRepository ApplicantRepository { get; set; }
        BlogRepository BlogRepository { get; set; }
        ContactRepository ContactRepository { get; set; }
        JudgeRepository JudgeRepository { get; set; }
        SeasonRepository SeasonRepository { get; set; }
    }
}