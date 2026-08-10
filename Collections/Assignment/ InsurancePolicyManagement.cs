using System;
using System.Collections.Generic;

public class Policy
{
    public string PolicyNumber { get; set; }
    public string HolderName { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(
        string policyNumber,
        string holderName,
        string coverageType,
        DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        HolderName = holderName;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override string ToString()
    {
        return $"{PolicyNumber} - {HolderName} - " +
               $"{CoverageType} - {ExpiryDate:dd-MM-yyyy}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Policy other)
        {
            return PolicyNumber == other.PolicyNumber;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }
}

public class InsurancePolicyManagement
{
    private HashSet<Policy> policies =
        new HashSet<Policy>();

    private List<Policy> insertionOrder =
        new List<Policy>();

    public void AddPolicy(Policy policy)
    {
        if (policies.Add(policy))
        {
            insertionOrder.Add(policy);
        }
        else
        {
            Console.WriteLine(
                $"Duplicate policy: {policy.PolicyNumber}");
        }
    }

    public void DisplayAllPolicies()
    {
        Console.WriteLine("\nAll Unique Policies:");

        foreach (Policy policy in policies)
        {
            Console.WriteLine(policy);
        }
    }

    public void DisplayInsertionOrder()
    {
        Console.WriteLine("\nPolicies in Insertion Order:");

        foreach (Policy policy in insertionOrder)
        {
            Console.WriteLine(policy);
        }
    }

    public void DisplayExpiringSoon()
    {
        DateTime today = DateTime.Today;
        DateTime next30Days = today.AddDays(30);

        Console.WriteLine(
            "\nPolicies Expiring Within 30 Days:");

        foreach (Policy policy in policies)
        {
            if (policy.ExpiryDate >= today &&
                policy.ExpiryDate <= next30Days)
            {
                Console.WriteLine(policy);
            }
        }
    }

    public void DisplayByCoverage(string coverageType)
    {
        Console.WriteLine(
            $"\nPolicies with {coverageType} Coverage:");

        foreach (Policy policy in policies)
        {
            if (policy.CoverageType.Equals(
                coverageType,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(policy);
            }
        }
    }

    public void FindDuplicates(List<Policy> inputPolicies)
    {
        HashSet<string> seen =
            new HashSet<string>();

        Console.WriteLine("\nDuplicate Policies:");

        foreach (Policy policy in inputPolicies)
        {
            if (!seen.Add(policy.PolicyNumber))
            {
                Console.WriteLine(policy.PolicyNumber);
            }
        }
    }
}